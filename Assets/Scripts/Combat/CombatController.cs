﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombatController : MonoBehaviour
{
    private FirstStrikeChance m_firstStrikeScript;

    private Dictionary<int, GameObject> m_battleOrder;

    [SerializeField]
    private List<GameObject> m_party;
    public List<GameObject> Party { get { return m_party; } set { m_party = value; } }

    public List<GameObject> EnemyList { get; set; }

    private int m_currentChar;

    public Text m_statusTxt;
    public Text m_rewardTxt;

    private int m_goldReward = 0;
    private int m_xpReward = 0;

    // analytics
    CombatData data;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<CombatCursorController>().CurrentPartyIndex = 0;

        // for testing 
        data = new CombatData { enemyCount = 0, id = 0, onAdvantage = 0, turnTotal = 0, victory = 0 };
        Combat();
    }

    // Update is called once per frame
    void Update()
    {
        if (CombatEnum.CombatState.ActionSelect == CombatEnum.s_currentCombatState)
        {
            m_statusTxt.text = "CHOOSE ACTION";

            if (GetComponent<CombatCursorController>().ChooseEnemyTarget)
            {
                m_statusTxt.text = "CHOOSE ENEMY";

                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    GetComponent<CombatCursorController>().RevertAttackAction();
                }
            }
            else
            {
                // action selection shortcuts
                if (Input.GetKeyDown(KeyCode.A))
                {
                    GetComponent<CombatCursorController>().AttackAction();
                }

                if (Input.GetKeyDown(KeyCode.F))
                {
                    GetComponent<CombatCursorController>().FleeAction();
                }

                if (Input.GetKeyDown(KeyCode.I))
                {
                    GetComponent<CombatCursorController>().ItemsAction();
                }
            }
        }

        else if (CombatEnum.CombatState.Battle == CombatEnum.s_currentCombatState)
        {
            GenEnemyActions();
            ExecuteBattleOrder();

            if (CombatEnum.CombatState.Victory != CombatEnum.s_currentCombatState &&
            CombatEnum.CombatState.Failure != CombatEnum.s_currentCombatState &&
            CombatEnum.CombatState.Escape != CombatEnum.s_currentCombatState)
            {
                CombatEnum.s_currentCombatState = CombatEnum.CombatState.ActionSelect;
                m_currentChar = -1;
                ChangeActivePartyMember();
            }
        }

        else if (CombatEnum.CombatState.Victory == CombatEnum.s_currentCombatState ||
            CombatEnum.CombatState.Failure == CombatEnum.s_currentCombatState ||
            CombatEnum.CombatState.Escape == CombatEnum.s_currentCombatState)
        {
            if (CombatEnum.CombatState.Victory == CombatEnum.s_currentCombatState)
            {
                m_rewardTxt.text = "REWARD: " + m_goldReward + 'G' + "\n                  " + m_xpReward + "XP";
            }

            else if (CombatEnum.CombatState.Escape == CombatEnum.s_currentCombatState)
            {
                m_statusTxt.text = "ESCAPED!";
            }

            if (Input.GetKeyDown(KeyCode.Return) ||
                Input.GetKeyDown(KeyCode.Escape) ||
                Input.GetMouseButtonDown(0))
            {
                if (CombatEnum.CombatState.Victory == CombatEnum.s_currentCombatState)
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_gil += m_goldReward;
                    Debug.Log("Enemy Killed: " + EnemyUtil.s_currentEnemyID);
                    EnemyUtil.s_enemyAliveStatus[EnemyUtil.s_currentEnemyID - 1] = false;
                    FindObjectOfType<ScreenSystem>().GoToGameplayScene();

                    DataCollectionUtility.PostData(data, this);
                }
                else if (CombatEnum.CombatState.Escape == CombatEnum.s_currentCombatState)
                {
                    FindObjectOfType<ScreenSystem>().GoToGameplayScene();

                    DataCollectionUtility.PostData(data, this);
                }
                else
                {
                    EnemyUtil.ResetEnemyStatus();
                    FindObjectOfType<ScreenSystem>().GoToScene(0);
                    DataCollectionUtility.PostData(data, this);
                }


            }

            else if (CombatEnum.CombatState.Battle == CombatEnum.s_currentCombatState)
            {
                GenEnemyActions();
                ExecuteBattleOrder();
                CombatEnum.s_currentCombatState = CombatEnum.CombatState.ActionSelect;
                m_currentChar = -1;
                ChangeActivePartyMember();
            }
        }
    }

    public void Combat()
    {
        if (!Utilities.s_testMode)
        {
            InitParty();
            GenerateEnemies();
            CalculateGoldXpRewards(ref m_goldReward, ref m_xpReward, EnemyList);
            StartCombat();
            GetComponent<GenerateGrids>().CreatePartyGrid();
            GetComponent<GenerateGrids>().CreateEnemyGrid();
            PositionPartyOnGrid();
            PositionEnemyOnGrid();

            GetComponent<CombatUIController>().SetupNameTexts(Party);
            GetComponent<CombatUIController>().UpdateHpTexts(Party);

            CombatEnum.s_currentCombatState = CombatEnum.CombatState.ActionSelect;

            m_currentChar = -1;
            ChangeActivePartyMember();
        }
        else
        {
            GenerateEnemies();
            StartCombat();
            GetComponent<GenerateGrids>().CreatePartyGrid();
            GetComponent<GenerateGrids>().CreateEnemyGrid();
        }
    }

    public void StartCombat()
    {
        m_battleOrder = new Dictionary<int, GameObject>();

        m_firstStrikeScript = GetComponent<FirstStrikeChance>();

        m_firstStrikeScript.SetOnAdvantage(CombatEnum.s_advantage);

        if (m_firstStrikeScript.FirstStrikeCheck())
        {
            Debug.Log("You get to strike first.");

            data.onAdvantage = 1;

            for (int i = 0; i < Party.Count; ++i)
            {
                m_battleOrder.Add(i + 1, Party[i]);
            }

            for (int i = 0; i < EnemyList.Count; ++i)
            {
                m_battleOrder.Add(i + Party.Count + 1, EnemyList[i]);
            }

            foreach (var item in m_battleOrder)
            {
                Debug.Log(item.Key + ": " + item.Value.GetComponent<CharacterAttributes>().Name);
            }
        }
        else
        {
            Debug.Log("Enemies strike first.");

            data.onAdvantage = 0;

            for (int i = 0; i < EnemyList.Count; ++i)
            {
                m_battleOrder.Add(i + 1, EnemyList[i]);
            }

            for (int i = 0; i < Party.Count; ++i)
            {
                m_battleOrder.Add(i + EnemyList.Count + 1, Party[i]);
            }

            foreach (var item in m_battleOrder)
            {
                Debug.Log(item.Key + ": " + item.Value.GetComponent<CharacterAttributes>().Name);
            }
        }
    }

    public void GenerateEnemies()
    {
        EnemyList = new List<GameObject>();

        GameObject characterTemp = Resources.Load<GameObject>("CharacterTemplate");

        int m_enemyCount = Random.Range(1, 10);

        data.enemyCount = m_enemyCount;

        for (int i = 0; i < m_enemyCount; i++)
        {
            GameObject enemy = Instantiate(characterTemp);

            EnemyType enemyType = (EnemyType)Random.Range(0, 7);

            switch (enemyType)
            {
                case EnemyType.Bandit:
                    EnemyUtil.SetupBandit(enemy.GetComponent<CharacterAttributes>());
                    enemy.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("bandit");
                    break;
                case EnemyType.DesertWarrior:
                    EnemyUtil.SetupWarrior(enemy.GetComponent<CharacterAttributes>());
                    enemy.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("desert-warrior");
                    break;
                case EnemyType.Cactus:
                    EnemyUtil.SetupCactus(enemy.GetComponent<CharacterAttributes>());
                    enemy.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("cactus-revenge");
                    break;
                case EnemyType.DesertShinobi:
                    EnemyUtil.SetupShinobiDesert(enemy.GetComponent<CharacterAttributes>());
                    enemy.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("desert-shinobi");
                    break;
                case EnemyType.DarkShinobi:
                    EnemyUtil.SetupShinobiDark(enemy.GetComponent<CharacterAttributes>());
                    enemy.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("dark-shinobi");
                    break;
                case EnemyType.ShadeShinobi:
                    EnemyUtil.SetupShinobiShade(enemy.GetComponent<CharacterAttributes>());
                    enemy.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("shade-shinobi");
                    break;
                case EnemyType.Snail:
                    EnemyUtil.SetupSnail(enemy.GetComponent<CharacterAttributes>());
                    enemy.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("snail");
                    break;
                default:
                    break;
            }

            EnemyList.Add(enemy);
        }
    }

    public List<GameObject> GenerateEnemiesTest()
    {
        List<GameObject> enemyTest = new List<GameObject>();

        GameObject characterTemp = Resources.Load<GameObject>("CharacterTemplate");

        int m_enemyCount = 1;

        for (int i = 0; i < m_enemyCount; i++)
        {
            GameObject enemy = Instantiate(characterTemp);

            EnemyType enemyType = EnemyType.Bandit;

            switch (enemyType)
            {
                case EnemyType.Bandit:
                    EnemyUtil.SetupBandit(enemy.GetComponent<CharacterAttributes>());
                    enemy.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("bandit");
                    break;
                case EnemyType.DesertWarrior:
                    EnemyUtil.SetupWarrior(enemy.GetComponent<CharacterAttributes>());
                    enemy.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("desert-warrior");
                    break;
                case EnemyType.Cactus:
                    EnemyUtil.SetupCactus(enemy.GetComponent<CharacterAttributes>());
                    enemy.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("cactus-revenge");
                    break;
                case EnemyType.DesertShinobi:
                    EnemyUtil.SetupShinobiDesert(enemy.GetComponent<CharacterAttributes>());
                    enemy.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("desert-shinobi");
                    break;
                case EnemyType.DarkShinobi:
                    EnemyUtil.SetupShinobiDark(enemy.GetComponent<CharacterAttributes>());
                    enemy.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("dark-shinobi");
                    break;
                case EnemyType.ShadeShinobi:
                    EnemyUtil.SetupShinobiShade(enemy.GetComponent<CharacterAttributes>());
                    enemy.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("shade-shinobi");
                    break;
                case EnemyType.Snail:
                    EnemyUtil.SetupSnail(enemy.GetComponent<CharacterAttributes>());
                    enemy.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("snail");
                    break;
                default:
                    break;
            }

            enemyTest.Add(enemy);
        }
        return enemyTest;
    }

    public void PositionPartyOnGrid()
    {
        for (int i = 0; i < Party.Count; ++i)
        {
            Party[i].transform.position = GetComponent<GenerateGrids>().PartyGrid[i, 1];
        }
    }

    public void PositionEnemyOnGrid()
    {
        int k = 0;

        for (int i = 0; i < GetComponent<GenerateGrids>().RowEnemy; ++i)
        {
            for (int j = 0; j < GetComponent<GenerateGrids>().ColumnEnemy; ++j)
            {
                EnemyList[k].transform.position = GetComponent<GenerateGrids>().EnemyGrid[j, i];
                ++k;

                if (k >= EnemyList.Count) break;
            }
            if (k >= EnemyList.Count) break;
        }
    }

    public void ChangeActivePartyMember()
    {
        // shift previous character back
        if (m_currentChar != -1) Party[m_currentChar].transform.position = GetComponent<GenerateGrids>().PartyGrid[m_currentChar, 1];

        m_currentChar++;
        GetComponent<CombatCursorController>().CurrentPartyIndex = m_currentChar;

        while (m_currentChar < Party.Count && !Party[m_currentChar].activeSelf)
        {
            m_currentChar++;
            GetComponent<CombatCursorController>().CurrentPartyIndex = m_currentChar;
            Debug.Log(GetComponent<CombatCursorController>().CurrentPartyIndex);
        }

        // if current character is the last character, return to first character and start battle
        if (m_currentChar >= Party.Count)
        {
            Party[Party.Count - 1].transform.position = GetComponent<GenerateGrids>().PartyGrid[Party.Count - 1, 1];
            m_currentChar = 0;
            GetComponent<CombatCursorController>().CurrentPartyIndex = m_currentChar;
            Debug.Log(GetComponent<CombatCursorController>().CurrentPartyIndex);
            CombatEnum.s_currentCombatState = CombatEnum.CombatState.Battle;
            return;
        }
        Party[m_currentChar].transform.position = GetComponent<GenerateGrids>().PartyGrid[m_currentChar, 0];
    }

    public void GenEnemyActions()
    {
        for (int i = 0; i < EnemyList.Count; ++i)
        {
            EnemyList[i].GetComponent<ActionController>().Action = ActionController.CombatAction.Fight;

            int targetPartyMember = Random.Range(0, 4);

            if (!Party[targetPartyMember].activeSelf)
            {
                --i;
                continue;
            }

            EnemyList[i].GetComponent<ActionController>().Target = Party[targetPartyMember];
        }
    }

    public void ExecuteBattleOrder()
    {
        foreach (var character in m_battleOrder)
        {
            if (character.Value.GetComponent<CharacterAttributes>().Playable)
            {
                if (character.Value.GetComponent<ActionController>().Action == ActionController.CombatAction.Fight && character.Value.activeSelf)
                {
                    //character.Value.transform.position = GetComponent<GenerateGrids>().PartyGrid[character.Key - 1, 0];
                    character.Value.GetComponent<ActionController>().ExecuteAction();
                    //character.Value.transform.position = GetComponent<GenerateGrids>().PartyGrid[character.Key - 1, 1];
                }
                else if (character.Value.activeSelf)
                {
                    character.Value.GetComponent<ActionController>().ExecuteAction();
                }
            }
            else if (character.Value.activeSelf)
            {
                character.Value.GetComponent<ActionController>().ExecuteAction();
            }

            if (CombatEnum.s_currentCombatState == CombatEnum.CombatState.Escape || BattleEnd()) return;
        }

        GetComponent<CombatUIController>().UpdateHpTexts(Party);

        data.turnTotal++;
    }

    private bool BattleEnd()
    {
        int enemyCount = 0;
        int partyCount = 0;

        foreach (var member in Party)
        {
            if (!member.activeSelf) partyCount++;
            if (partyCount >= Party.Count)
            {
                CombatEnum.s_currentCombatState = CombatEnum.CombatState.Failure;
                Debug.Log("You have lost the battle...");
                m_statusTxt.text = "YOU LOST THE BATTLE...";
                data.victory = 0;
                return true;
            }
        }

        foreach (var enemy in EnemyList)
        {
            if (!enemy.activeSelf) enemyCount++;
            if (enemyCount >= EnemyList.Count)
            {
                CombatEnum.s_currentCombatState = CombatEnum.CombatState.Victory;
                Debug.Log("All enemies terminated!");
                m_statusTxt.text = "YOU WON THE BATTLE!";
                UpdateStats();

                data.victory = 1;

                FindObjectOfType<EndPoint>().FightWon();
                return true;
            }
        }

        return false;
    }

    public bool BattleEndTest(List<GameObject> party, List<GameObject> enemies)
    {
        int enemyCount = 0;
        int partyCount = 0;

        foreach (var member in party)
        {
            if (!member.activeSelf) partyCount++;
            if (partyCount >= party.Count)
            {
                CombatEnum.s_currentCombatState = CombatEnum.CombatState.Failure;
                return true;
            }
        }

        foreach (var enemy in enemies)
        {
            if (!enemy.activeSelf) enemyCount++;
            if (enemyCount >= enemies.Count)
            {
                CombatEnum.s_currentCombatState = CombatEnum.CombatState.Victory;
                return true;
            }
        }

        return false;
    }

    public void InitParty()
    {
        m_party[0].GetComponent<CharacterAttributes>().FindAttribute("MHP").Value = FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHPMax1.Value;
        m_party[0].GetComponent<CharacterAttributes>().FindAttribute("HP").Value = FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP1.Value;
        m_party[0].GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value = FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeDam1.Value;
        m_party[0].GetComponent<CharacterAttributes>().FindAttribute("Def").Value = FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor1.Value;
        m_party[0].GetComponent<CharacterAttributes>().FindAttribute("Ack").Value = FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeAttack1.Value;

        m_party[0].GetComponent<CharacterAttributes>().Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_name1;
        m_party[0].GetComponent<SpriteRenderer>().sprite = FindObjectOfType<PlayerAndGameInfo>().infos.m_charImage1;
        
        m_party[0].GetComponent<CharacterAttributes>().Level = FindObjectOfType<PlayerAndGameInfo>().infos.m_lvl1;
        m_party[0].GetComponent<CharacterAttributes>().Xp = FindObjectOfType<PlayerAndGameInfo>().infos.m_xp1;
        m_party[0].GetComponent<CharacterAttributes>().LevelUpThreshold = FindObjectOfType<PlayerAndGameInfo>().infos.m_lvlThreshold1;

        m_party[1].GetComponent<CharacterAttributes>().FindAttribute("MHP").Value = FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHPMax2.Value;
        m_party[1].GetComponent<CharacterAttributes>().FindAttribute("HP").Value = FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP2.Value;
        m_party[1].GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value = FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeDam2.Value;
        m_party[1].GetComponent<CharacterAttributes>().FindAttribute("Def").Value = FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor2.Value;
        m_party[1].GetComponent<CharacterAttributes>().FindAttribute("Ack").Value = FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeAttack2.Value;

        m_party[1].GetComponent<CharacterAttributes>().Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_name2;
        m_party[1].GetComponent<SpriteRenderer>().sprite = FindObjectOfType<PlayerAndGameInfo>().infos.m_charImage2;

        m_party[1].GetComponent<CharacterAttributes>().Level = FindObjectOfType<PlayerAndGameInfo>().infos.m_lvl2;
        m_party[1].GetComponent<CharacterAttributes>().Xp = FindObjectOfType<PlayerAndGameInfo>().infos.m_xp2;
        m_party[1].GetComponent<CharacterAttributes>().LevelUpThreshold = FindObjectOfType<PlayerAndGameInfo>().infos.m_lvlThreshold2;

        m_party[2].GetComponent<CharacterAttributes>().FindAttribute("MHP").Value = FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHPMax3.Value;
        m_party[2].GetComponent<CharacterAttributes>().FindAttribute("HP").Value = FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP3.Value;
        m_party[2].GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value = FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeDam3.Value;
        m_party[2].GetComponent<CharacterAttributes>().FindAttribute("Def").Value = FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor3.Value;
        m_party[2].GetComponent<CharacterAttributes>().FindAttribute("Ack").Value = FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeAttack3.Value;

        m_party[2].GetComponent<CharacterAttributes>().Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_name3;
        m_party[2].GetComponent<SpriteRenderer>().sprite = FindObjectOfType<PlayerAndGameInfo>().infos.m_charImage3;

        m_party[2].GetComponent<CharacterAttributes>().Level = FindObjectOfType<PlayerAndGameInfo>().infos.m_lvl3;
        m_party[2].GetComponent<CharacterAttributes>().Xp = FindObjectOfType<PlayerAndGameInfo>().infos.m_xp3;
        m_party[2].GetComponent<CharacterAttributes>().LevelUpThreshold = FindObjectOfType<PlayerAndGameInfo>().infos.m_lvlThreshold3;

        m_party[3].GetComponent<CharacterAttributes>().FindAttribute("MHP").Value = FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHPMax4.Value;
        m_party[3].GetComponent<CharacterAttributes>().FindAttribute("HP").Value = FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP4.Value;
        m_party[3].GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value = FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeDam4.Value;
        m_party[3].GetComponent<CharacterAttributes>().FindAttribute("Def").Value = FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor4.Value;
        m_party[3].GetComponent<CharacterAttributes>().FindAttribute("Ack").Value = FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeAttack4.Value;

        m_party[3].GetComponent<CharacterAttributes>().Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_name4;
        m_party[3].GetComponent<SpriteRenderer>().sprite = FindObjectOfType<PlayerAndGameInfo>().infos.m_charImage4;

        m_party[3].GetComponent<CharacterAttributes>().Level = FindObjectOfType<PlayerAndGameInfo>().infos.m_lvl4;
        m_party[3].GetComponent<CharacterAttributes>().Xp = FindObjectOfType<PlayerAndGameInfo>().infos.m_xp4;
        m_party[3].GetComponent<CharacterAttributes>().LevelUpThreshold = FindObjectOfType<PlayerAndGameInfo>().infos.m_lvlThreshold4;

        foreach (var member in m_party)
        {
            if (member.GetComponent<CharacterAttributes>().FindAttribute("HP").Value <= 0.0f)
            {
                member.SetActive(false);
            }
        }
    }

    public void UpdateStats()
    { 
        // member 1
        if (m_party[0].activeSelf)
        {
            m_party[0].GetComponent<CharacterAttributes>().Xp += m_xpReward;

            if (m_party[0].GetComponent<CharacterAttributes>().Xp >= m_party[0].GetComponent<CharacterAttributes>().LevelUpThreshold)
            {
                Party[0].transform.GetChild(0).gameObject.SetActive(true);

                switch (FindObjectOfType<PlayerAndGameInfo>().infos.m_type1)
                {
                    case (int)PartyType.Fighter:
                        PartyUtil.LevelUpFighter(m_party[0].GetComponent<CharacterAttributes>());
                        break;
                    case (int)PartyType.B_Mage:
                        PartyUtil.LevelUpMage(m_party[0].GetComponent<CharacterAttributes>());
                        break;
                    case (int)PartyType.Thief:
                        PartyUtil.LevelUpThief(m_party[0].GetComponent<CharacterAttributes>());
                        break;
                    case (int)PartyType.BL_Belt:
                        PartyUtil.LevelUpBlackBelt(m_party[0].GetComponent<CharacterAttributes>());
                        break;
                }
            }
        }

        FindObjectOfType<PlayerAndGameInfo>().infos.m_xp1 = m_party[0].GetComponent<CharacterAttributes>().Xp;
        FindObjectOfType<PlayerAndGameInfo>().infos.m_lvl1 = m_party[0].GetComponent<CharacterAttributes>().Level;
        FindObjectOfType<PlayerAndGameInfo>().infos.m_lvlThreshold1 = m_party[0].GetComponent<CharacterAttributes>().LevelUpThreshold;
        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP1.Value = m_party[0].GetComponent<CharacterAttributes>().FindAttribute("HP").Value;
        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHPMax1.Value = m_party[0].GetComponent<CharacterAttributes>().FindAttribute("MHP").Value;
        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeDam1.Value = m_party[0].GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value;


        // member 2
        if (m_party[1].activeSelf)
        {
            m_party[1].GetComponent<CharacterAttributes>().Xp += m_xpReward;

            if (m_party[1].GetComponent<CharacterAttributes>().Xp >= m_party[1].GetComponent<CharacterAttributes>().LevelUpThreshold)
            {
                Party[1].transform.GetChild(0).gameObject.SetActive(true);

                switch (FindObjectOfType<PlayerAndGameInfo>().infos.m_type1)
                {
                    case (int)PartyType.Fighter:
                        PartyUtil.LevelUpFighter(m_party[1].GetComponent<CharacterAttributes>());
                        break;
                    case (int)PartyType.B_Mage:
                        PartyUtil.LevelUpMage(m_party[1].GetComponent<CharacterAttributes>());
                        break;
                    case (int)PartyType.Thief:
                        PartyUtil.LevelUpThief(m_party[1].GetComponent<CharacterAttributes>());
                        break;
                    case (int)PartyType.BL_Belt:
                        PartyUtil.LevelUpBlackBelt(m_party[1].GetComponent<CharacterAttributes>());
                        break;
                }
            }
        }

        FindObjectOfType<PlayerAndGameInfo>().infos.m_xp2 = m_party[1].GetComponent<CharacterAttributes>().Xp;
        FindObjectOfType<PlayerAndGameInfo>().infos.m_lvl2 = m_party[1].GetComponent<CharacterAttributes>().Level;
        FindObjectOfType<PlayerAndGameInfo>().infos.m_lvlThreshold2 = m_party[1].GetComponent<CharacterAttributes>().LevelUpThreshold;
        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP2.Value = m_party[1].GetComponent<CharacterAttributes>().FindAttribute("HP").Value;
        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHPMax2.Value = m_party[1].GetComponent<CharacterAttributes>().FindAttribute("MHP").Value;
        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeDam2.Value = m_party[1].GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value;


        // member 3
        if (m_party[2].activeSelf)
        {
            m_party[2].GetComponent<CharacterAttributes>().Xp += m_xpReward;

            if (m_party[2].GetComponent<CharacterAttributes>().Xp >= m_party[2].GetComponent<CharacterAttributes>().LevelUpThreshold)
            {
                Party[2].transform.GetChild(0).gameObject.SetActive(true);

                switch (FindObjectOfType<PlayerAndGameInfo>().infos.m_type1)
                {
                    case (int)PartyType.Fighter:
                        PartyUtil.LevelUpFighter(m_party[2].GetComponent<CharacterAttributes>());
                        break;
                    case (int)PartyType.B_Mage:
                        PartyUtil.LevelUpMage(m_party[2].GetComponent<CharacterAttributes>());
                        break;
                    case (int)PartyType.Thief:
                        PartyUtil.LevelUpThief(m_party[2].GetComponent<CharacterAttributes>());
                        break;
                    case (int)PartyType.BL_Belt:
                        PartyUtil.LevelUpBlackBelt(m_party[2].GetComponent<CharacterAttributes>());
                        break;
                }
            }
        }

        FindObjectOfType<PlayerAndGameInfo>().infos.m_xp3 = m_party[2].GetComponent<CharacterAttributes>().Xp;
        FindObjectOfType<PlayerAndGameInfo>().infos.m_lvl3 = m_party[2].GetComponent<CharacterAttributes>().Level;
        FindObjectOfType<PlayerAndGameInfo>().infos.m_lvlThreshold3 = m_party[2].GetComponent<CharacterAttributes>().LevelUpThreshold;
        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP3.Value = m_party[2].GetComponent<CharacterAttributes>().FindAttribute("HP").Value;
        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHPMax3.Value = m_party[2].GetComponent<CharacterAttributes>().FindAttribute("MHP").Value;
        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeDam3.Value = m_party[2].GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value;


        // member 4
        if (m_party[3].activeSelf)
        {
            m_party[3].GetComponent<CharacterAttributes>().Xp += m_xpReward;

            if (m_party[3].GetComponent<CharacterAttributes>().Xp >= m_party[3].GetComponent<CharacterAttributes>().LevelUpThreshold)
            {
                Party[3].transform.GetChild(0).gameObject.SetActive(true);

                switch (FindObjectOfType<PlayerAndGameInfo>().infos.m_type1)
                {
                    case (int)PartyType.Fighter:
                        PartyUtil.LevelUpFighter(m_party[3].GetComponent<CharacterAttributes>());
                        break;
                    case (int)PartyType.B_Mage:
                        PartyUtil.LevelUpMage(m_party[3].GetComponent<CharacterAttributes>());
                        break;
                    case (int)PartyType.Thief:
                        PartyUtil.LevelUpThief(m_party[3].GetComponent<CharacterAttributes>());
                        break;
                    case (int)PartyType.BL_Belt:
                        PartyUtil.LevelUpBlackBelt(m_party[3].GetComponent<CharacterAttributes>());
                        break;
                }
            }
        }

        FindObjectOfType<PlayerAndGameInfo>().infos.m_xp4 = m_party[3].GetComponent<CharacterAttributes>().Xp;
        FindObjectOfType<PlayerAndGameInfo>().infos.m_lvl4 = m_party[3].GetComponent<CharacterAttributes>().Level;
        FindObjectOfType<PlayerAndGameInfo>().infos.m_lvlThreshold4 = m_party[3].GetComponent<CharacterAttributes>().LevelUpThreshold;
        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP4.Value = m_party[3].GetComponent<CharacterAttributes>().FindAttribute("HP").Value;
        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHPMax4.Value = m_party[3].GetComponent<CharacterAttributes>().FindAttribute("MHP").Value;
        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeDam4.Value = m_party[3].GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value;
    }

    public static void CalculateGoldXpRewards(ref int goldReward, ref int xpReward, List<GameObject> enemies)
    {
        foreach (var enemy in enemies)
        {
            goldReward += enemy.GetComponent<CharacterAttributes>().Gold;
            xpReward += enemy.GetComponent<CharacterAttributes>().Xp;
        }
    }
}
