using System.Collections.Generic;
using UnityEngine;

public class CombatController : MonoBehaviour
{
    private FirstStrikeChance m_firstStrikeScript;

    private Dictionary<int, GameObject> m_battleOrder;

    [SerializeField]
    private List<GameObject> m_party;
    public List<GameObject> Party { get { return m_party; } set { m_party = value; } }

    public List<GameObject> EnemyList { get; set; }

    private int m_currentChar;

    // Start is called before the first frame update
    void Start()
    {
        Combat();
    }

    // Update is called once per frame
    void Update()
    {
        if (CombatEnum.CombatState.ActionSelect == CombatEnum.s_currentCombatState)
        {
            if (Input.GetKeyUp(KeyCode.LeftArrow)) GetComponent<CombatCursorController>().MoveCol(-1);
            if (Input.GetKeyUp(KeyCode.RightArrow)) GetComponent<CombatCursorController>().MoveCol(1);

            if (Input.GetKeyUp(KeyCode.UpArrow)) GetComponent<CombatCursorController>().MoveRow(-1);
            if (Input.GetKeyUp(KeyCode.DownArrow)) GetComponent<CombatCursorController>().MoveRow(1);

            if (GetComponent<CombatCursorController>().DecideAction)
            {
                if (Input.GetKeyUp(KeyCode.Return)) GetComponent<CombatCursorController>().ChooseAction(m_currentChar);
            }

            else if (GetComponent<CombatCursorController>().ChooseEnemyTarget)
            {
                if (Input.GetKeyUp(KeyCode.Return)) GetComponent<CombatCursorController>().ChooseTarget(m_currentChar);
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
            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (CombatEnum.CombatState.Victory == CombatEnum.s_currentCombatState)
                {
                    // implement rewards here
                }

                // switch scenes here
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
            // run first strike check in start() for now
            GenerateEnemies();
            StartCombat();
            GetComponent<GenerateGrids>().CreatePartyGrid();
            GetComponent<GenerateGrids>().CreateEnemyGrid();
            PositionPartyOnGrid();
            PositionEnemyOnGrid();

            GetComponent<CombatUIController>().SetupNameTexts(Party);
            GetComponent<CombatUIController>().UpdateHpTexts(Party);

            CombatEnum.s_currentCombatState = CombatEnum.CombatState.ActionSelect;
            GetComponent<CombatCursorController>().SetupCursor();
            GetComponent<CombatCursorController>().EnterActionSelect();

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

        if (m_firstStrikeScript.FirstStrikeCheck())
        {
            Debug.Log("You get to strike first.");

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

        for (int i = 0; i < m_enemyCount; i++)
        {
            GameObject enemy = Instantiate(characterTemp);

            EnemyType enemyType = EnemyType.Imp;

            switch (enemyType)
            {
                case EnemyType.Imp:
                    EnemyUtil.SetupImp(enemy.GetComponent<CharacterAttributes>());
                    enemy.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("imp-sprite");
                    break;
                case EnemyType.Wolf:
                    EnemyUtil.SetupWolf(enemy.GetComponent<CharacterAttributes>());
                    break;
                case EnemyType.Spider:
                    EnemyUtil.SetupSpider(enemy.GetComponent<CharacterAttributes>());
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

            EnemyType enemyType = EnemyType.Imp;

            switch (enemyType)
            {
                case EnemyType.Imp:
                    EnemyUtil.SetupImp(enemy.GetComponent<CharacterAttributes>());
                    enemy.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("imp-sprite");
                    break;
                case EnemyType.Wolf:
                    EnemyUtil.SetupWolf(enemy.GetComponent<CharacterAttributes>());
                    break;
                case EnemyType.Spider:
                    EnemyUtil.SetupSpider(enemy.GetComponent<CharacterAttributes>());
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

        while (m_currentChar < Party.Count && !Party[m_currentChar].activeSelf)
        {
            m_currentChar++;
        }

        // if current character is the last character, return to first character and start battle
        if (m_currentChar >= Party.Count)
        {
            Party[Party.Count - 1].transform.position = GetComponent<GenerateGrids>().PartyGrid[Party.Count - 1, 1];
            m_currentChar = 0;
            CombatEnum.s_currentCombatState = CombatEnum.CombatState.Battle;
            return;
        }
        Party[m_currentChar].transform.position = GetComponent<GenerateGrids>().PartyGrid[m_currentChar, 0];
    }

    public void GenEnemyActions()
    {
        foreach (var enemy in EnemyList)
        {
            enemy.GetComponent<ActionController>().Action = ActionController.CombatAction.Fight;

            int targetPartyMember = Random.Range(0, 4);

            enemy.GetComponent<ActionController>().Target = Party[targetPartyMember];
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
}
