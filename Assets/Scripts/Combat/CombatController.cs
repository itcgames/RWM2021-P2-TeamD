using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombatController : MonoBehaviour
{
    private FirstStrikeChance m_firstStrikeScript;

    private Dictionary<int, GameObject> m_battleOrder;

    private float m_battleWait = 1.5f;

    [SerializeField]
    private List<GameObject> m_party;
    public List<GameObject> Party { get { return m_party; } set { m_party = value; } }
    public Vector2[] PartyInitPositions;
    public Vector2[] EnemyInitPositions;
    public List<GameObject> EnemyList { get; set; }

    private GameObject[] EnemySelectors;
    private GameObject[] XpBars;

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
        EnemySelectors = new GameObject[9];
        XpBars = new GameObject[4];
        
        PartyInitPositions = new Vector2[4];
        EnemyInitPositions = new Vector2[9];

        GetComponent<CombatCursorController>().CurrentPartyIndex = 0;

        // for testing 
        data = new CombatData { enemyCount = 0, id = 0, onAdvantage = 0, turnTotal = 0, victory = 0 };
        SetupSelectors();
        SetupXpBars();
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

                if (Input.GetMouseButtonUp(1))
                {
                    GetComponent<CombatCursorController>().RevertAttackAction();
                    //cancel sound
                }
            }
            else
            {
                // action selection shortcuts
                if (Input.GetMouseButtonUp(1))
                {
                    GetComponent<CombatCursorController>().AttackAction();
                }

                if (Input.GetKeyDown(KeyCode.F))
                {
                    GetComponent<CombatCursorController>().FleeAction();
                }

                if (Input.GetKeyDown(KeyCode.B))
                {
                    GetComponent<CombatCursorController>().BlockAction();
                }
            }
        }

        else if (CombatEnum.CombatState.Battle == CombatEnum.s_currentCombatState)
        {
            GenEnemyActions();
            StartCoroutine(ExecuteBattleOrder());
            CombatEnum.s_currentCombatState = CombatEnum.CombatState.Inactive;
        }

        else if (CombatEnum.CombatState.Victory == CombatEnum.s_currentCombatState ||
            CombatEnum.CombatState.Failure == CombatEnum.s_currentCombatState ||
            CombatEnum.CombatState.Escape == CombatEnum.s_currentCombatState)
        {
            if (CombatEnum.CombatState.Victory == CombatEnum.s_currentCombatState)
            {
                if (FindObjectOfType<PlayerAndGameInfo>().infos.quest1Triggered
                    || FindObjectOfType<PlayerAndGameInfo>().infos.quest2Triggered
                        || FindObjectOfType<PlayerAndGameInfo>().infos.quest3Triggered)
                {
                    m_rewardTxt.text = "REWARD: " + m_goldReward + 'G' + "\n                  " + m_xpReward + "XP\nGOT NEW GEAR";
                }
                else
                {
                    m_rewardTxt.text = "REWARD: " + m_goldReward + 'G' + "\n                  " + m_xpReward + "XP";
                }
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
                    Debug.Log("Enemy Killed: " + EnemyUtil.s_currentEnemyID);
                    if (!FindObjectOfType<PlayerAndGameInfo>().infos.quest1Triggered && !FindObjectOfType<PlayerAndGameInfo>().infos.quest2Triggered
                        && !FindObjectOfType<PlayerAndGameInfo>().infos.quest3Triggered)
                    {
                        EnemyUtil.s_enemyAliveStatus[EnemyUtil.s_currentEnemyID - 1] = false;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.quest1Triggered == true)
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.quest1Triggered = false;
                        FindObjectOfType<PlayerAndGameInfo>().infos.quest1Finished = true;
                    }
                     if (FindObjectOfType<PlayerAndGameInfo>().infos.quest2Triggered == true)
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.quest2Triggered = false;
                        FindObjectOfType<PlayerAndGameInfo>().infos.quest2Finished = true;
                    }
                     if (FindObjectOfType<PlayerAndGameInfo>().infos.quest3Triggered == true)
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.quest3Triggered = false;
                        FindObjectOfType<PlayerAndGameInfo>().infos.quest3Finished = true;
                    }
                    FindObjectOfType<ScreenSystem>().GoToGameplayScene();

                    DataCollectionUtility.PostData(data, this);
                }
                else if (CombatEnum.CombatState.Escape == CombatEnum.s_currentCombatState)
                {
                    UpdateStats();
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
            UpdateXpBars();

            if (FindObjectOfType<PlayerAndGameInfo>().infos.quest1Triggered == true)
            {
                SpawnBoss();

            }
            if (FindObjectOfType<PlayerAndGameInfo>().infos.quest2Triggered == true)
            {
                SpawnBoss2();

            }
            if (FindObjectOfType<PlayerAndGameInfo>().infos.quest3Triggered == true)
            {
                SpawnBoss3();

            }
            else if(FindObjectOfType<PlayerAndGameInfo>().infos.quest1Triggered == false && FindObjectOfType<PlayerAndGameInfo>().infos.quest2Triggered == false && FindObjectOfType<PlayerAndGameInfo>().infos.quest3Triggered == false)
            {
                GenerateEnemies();
            }

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
        //music play
        if (AudioManager.instance != null)
        {
            AudioManager.instance.PauseMusic("Theme");
            AudioManager.instance.PlayMusic("BattleTheme");
        }
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
            PartyInitPositions[i] = GetComponent<GenerateGrids>().PartyGrid[i, 1];
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
                EnemyInitPositions[k] = GetComponent<GenerateGrids>().EnemyGrid[j, i];
                ++k;

                if (k >= EnemyList.Count) break;
            }
            if (k >= EnemyList.Count) break;
        }
    }

    public void ChangeActivePartyMember()
    {
        // shift previous character back
        if (m_currentChar != -1)
        {
            Party[m_currentChar].transform.position = GetComponent<GenerateGrids>().PartyGrid[m_currentChar, 1];
            PartyInitPositions[m_currentChar] = GetComponent<GenerateGrids>().PartyGrid[m_currentChar, 1];
        }

        m_currentChar++;
        GetComponent<CombatCursorController>().CurrentPartyIndex = m_currentChar;

        while (m_currentChar < Party.Count && !Party[m_currentChar].activeSelf)
        {
            m_currentChar++;
            GetComponent<CombatCursorController>().CurrentPartyIndex = m_currentChar;
        }

        // if current character is the last character, return to first character and start battle
        if (m_currentChar >= Party.Count)
        {
            Party[Party.Count - 1].transform.position = GetComponent<GenerateGrids>().PartyGrid[Party.Count - 1, 1];
            PartyInitPositions[Party.Count - 1] = GetComponent<GenerateGrids>().PartyGrid[Party.Count - 1, 1];
            m_currentChar = 0;
            GetComponent<CombatCursorController>().CurrentPartyIndex = m_currentChar;
            Debug.Log(GetComponent<CombatCursorController>().CurrentPartyIndex);
            CombatEnum.s_currentCombatState = CombatEnum.CombatState.Battle;
            return;
        }
        Party[m_currentChar].transform.position = GetComponent<GenerateGrids>().PartyGrid[m_currentChar, 0];
        PartyInitPositions[m_currentChar] = GetComponent<GenerateGrids>().PartyGrid[m_currentChar, 0];
    }

    public void GenEnemyActions()
    {
        for (int i = 0; i < EnemyList.Count; ++i)
        {
            if (!EnemyList[i].activeSelf) continue;

            // if hp less than half
            if(EnemyList[i].GetComponent<CharacterAttributes>().FindAttribute("HP").Value <=
                EnemyList[i].GetComponent<CharacterAttributes>().FindAttribute("MHP").Value / 2)
            {
                int chance = Random.Range(1, 101);

                if(chance >= 60)
                {
                    EnemyList[i].GetComponent<ActionController>().Action = ActionController.CombatAction.Block;
                    EnemyList[i].GetComponent<ActionController>().StatusTxt = m_statusTxt;
                    continue;
                }
            }

            EnemyList[i].GetComponent<ActionController>().Action = ActionController.CombatAction.Fight;

            int targetPartyMember = Random.Range(0, 4);

            if (!Party[targetPartyMember].activeSelf)
            {
                --i;
                continue;
            }

            EnemyList[i].GetComponent<ActionController>().Target = Party[targetPartyMember];
            EnemyList[i].GetComponent<ActionController>().TargetInitPos = PartyInitPositions[targetPartyMember];
            EnemyList[i].GetComponent<ActionController>().StatusTxt = m_statusTxt;
        }
    }

    public void GetNewEnemyTarget(out GameObject newTarget, out Vector2 newTargetInitPos)
    {
        newTarget = null;
        newTargetInitPos = new Vector2();

        for (int i = 0; i < EnemyList.Count; ++i)
        {
            if(EnemyList[i].activeSelf)
            {
                newTarget = EnemyList[i];
                newTargetInitPos = EnemyInitPositions[i];
            }
        }
    }

    public void GetNewPartyTarget(out GameObject newTarget, out Vector2 newTargetInitPos)
    {
        newTarget = null;
        newTargetInitPos = new Vector2();

        for (int i = 0; i < Party.Count; ++i)
        {
            if (Party[i].activeSelf)
            {
                newTarget = Party[i];
                newTargetInitPos = PartyInitPositions[i];
            }
        }
    }

    public IEnumerator ExecuteBattleOrder()
    {
        int playableChar = -1;

        foreach (var character in m_battleOrder)
        {
            if (character.Value.activeSelf)
            {
                if (character.Value.GetComponent<CharacterAttributes>().Playable)
                {
                    playableChar++;
                    if (character.Value.GetComponent<ActionController>().Action == ActionController.CombatAction.Fight)
                    {
                        character.Value.transform.position = GetComponent<GenerateGrids>().PartyGrid[playableChar, 0];
                    }
                    character.Value.GetComponent<ActionController>().ExecuteAction();
                    GetComponent<CombatUIController>().UpdateHpTexts(Party);
                    UpdateHpBars();
                    yield return new WaitForSeconds(m_battleWait);
                    character.Value.transform.position = GetComponent<GenerateGrids>().PartyGrid[playableChar, 1];
                }
                else
                {
                    character.Value.GetComponent<ActionController>().ExecuteAction();
                    GetComponent<CombatUIController>().UpdateHpTexts(Party);
                    UpdateHpBars();
                    yield return new WaitForSeconds(m_battleWait);
                }
            }
            else if (!character.Value.activeSelf)
            {
                if (character.Value.GetComponent<CharacterAttributes>().Playable)
                {
                    playableChar++;
                }
            }

            if (CombatEnum.s_currentCombatState == CombatEnum.CombatState.Escape || BattleEnd()) yield break;
        }

        data.turnTotal++;

        if (CombatEnum.CombatState.Victory != CombatEnum.s_currentCombatState &&
            CombatEnum.CombatState.Failure != CombatEnum.s_currentCombatState &&
            CombatEnum.CombatState.Escape != CombatEnum.s_currentCombatState)
        {
            CombatEnum.s_currentCombatState = CombatEnum.CombatState.ActionSelect;
            m_currentChar = -1;
            ChangeActivePartyMember();
        }
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
                UpdateXpBars();

                data.victory = 1;

                if (AudioManager.instance != null)
                {
                    AudioManager.instance.PauseMusic("BattleTheme");
                    AudioManager.instance.PlayMusic("Theme");
                }
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
        if (CombatEnum.CombatState.Escape != CombatEnum.s_currentCombatState)
        {
            // updating gold
            FindObjectOfType<PlayerAndGameInfo>().infos.m_gil += m_goldReward;
        }

        // member 1
        if (m_party[0].activeSelf && CombatEnum.CombatState.Escape != CombatEnum.s_currentCombatState)
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
        if (m_party[1].activeSelf && CombatEnum.CombatState.Escape != CombatEnum.s_currentCombatState)
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
        if (m_party[2].activeSelf && CombatEnum.CombatState.Escape != CombatEnum.s_currentCombatState)
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
        if (m_party[3].activeSelf && CombatEnum.CombatState.Escape != CombatEnum.s_currentCombatState)
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

    public void UpdateHpBars()
    {
        foreach (var selector in EnemySelectors)
        {
            selector.GetComponent<EnemySelector>().transform.GetChild(0).GetComponent<HPDisplayController>().UpdateHpBar(selector.GetComponent<EnemySelector>());
        }
    }

    void SetupSelectors()
    {
        for (int i = 0; i < EnemySelectors.Length; ++i)
        {
            Debug.Log("EnemyPos" + (i + 1).ToString());
            EnemySelectors[i] = GameObject.Find("EnemyPos" + (i + 1).ToString());
        }
    }

    void SetupXpBars()
    {
        for (int i = 0; i < XpBars.Length; ++i)
        {
            Debug.Log("XpBar" + (i + 1).ToString());
            XpBars[i] = GameObject.Find("XPBar" + (i + 1).ToString());
        }
    }

    public void UpdateXpBars()
    {
        for (int i = 0; i < XpBars.Length; ++i)
        {
            XpBars[i].GetComponent<XpBarController>().UpdateXpBar(Party[i]);
        }
    }

    public void SpawnBoss()
    {
        EnemyList = new List<GameObject>();

        GameObject characterTemp = Resources.Load<GameObject>("CharacterTemplate");

        int m_enemyCount = 3;

        data.enemyCount = m_enemyCount;

        for (int i = 0; i < m_enemyCount; i++)
        {
            GameObject enemy = Instantiate(characterTemp);

            EnemyUtil.SetupBandit(enemy.GetComponent<CharacterAttributes>());
            enemy.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("bandit");

            EnemyList.Add(enemy);
        }

        GameObject temp = Instantiate(characterTemp);
        EnemyList.Add(temp);
        EnemyList[EnemyList.IndexOf(temp)].SetActive(false);

        GameObject boss = Instantiate(characterTemp);

        EnemyUtil.SetupBossMan(boss.GetComponent<CharacterAttributes>());
        boss.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("boss-man");

        EnemyList.Add(boss);
    }
    public void SpawnBoss3()
    {
        EnemyList = new List<GameObject>();

        GameObject characterTemp = Resources.Load<GameObject>("CharacterTemplate");

        int m_enemyCount = 3;

        data.enemyCount = m_enemyCount;

        for (int i = 0; i < m_enemyCount; i++)
        {
            GameObject enemy = Instantiate(characterTemp);

            EnemyUtil.SetupShinobiDark(enemy.GetComponent<CharacterAttributes>());
            enemy.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("dark-shinobi");

            EnemyList.Add(enemy);
        }

        GameObject temp = Instantiate(characterTemp);
        EnemyList.Add(temp);
        EnemyList[EnemyList.IndexOf(temp)].SetActive(false);

        GameObject boss = Instantiate(characterTemp);

        EnemyUtil.SetupBossWalk(boss.GetComponent<CharacterAttributes>());
        boss.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("boss-walk");

        EnemyList.Add(boss);
    }
    public void SpawnBoss2()
    {
        EnemyList = new List<GameObject>();

        GameObject characterTemp = Resources.Load<GameObject>("CharacterTemplate");

        int m_enemyCount = 3;

        data.enemyCount = m_enemyCount;

        for (int i = 0; i < m_enemyCount; i++)
        {
            GameObject enemy = Instantiate(characterTemp);

            EnemyUtil.SetupWarrior(enemy.GetComponent<CharacterAttributes>());
            enemy.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("desert-warrior");

            EnemyList.Add(enemy);
        }

        GameObject temp = Instantiate(characterTemp);
        EnemyList.Add(temp);
        EnemyList[EnemyList.IndexOf(temp)].SetActive(false);

        GameObject boss = Instantiate(characterTemp);

        EnemyUtil.SetupBossBoss(boss.GetComponent<CharacterAttributes>());
        boss.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("boss-boss");

        EnemyList.Add(boss);
    }
}
