using System.Collections.Generic;
using UnityEngine;

public class CombatController : MonoBehaviour
{
    private FirstStrikeChance m_firstStrikeScript;

    private Dictionary<int, GameObject> m_battleOrder;

    [SerializeField]
    public List<GameObject> m_party;

    private List<GameObject> m_enemies;

    private int m_currentChar;

    // Start is called before the first frame update
    void Start()
    {
        Combat();
    }

    // Update is called once per frame
    void Update()
    {
        if(CombatEnum.CombatState.ActionSelect == CombatEnum.s_currentCombatState)
        {
            if (Input.GetKeyUp(KeyCode.LeftArrow)) GetComponent<CombatCursorController>().MoveCol(-1);
            if (Input.GetKeyUp(KeyCode.RightArrow)) GetComponent<CombatCursorController>().MoveCol(1);

            if (Input.GetKeyUp(KeyCode.UpArrow)) GetComponent<CombatCursorController>().MoveRow(-1);
            if (Input.GetKeyUp(KeyCode.DownArrow)) GetComponent<CombatCursorController>().MoveRow(1);

            if (Input.GetKeyUp(KeyCode.Return)) GetComponent<CombatCursorController>().ChooseAction(0);
        }

        else if(CombatEnum.CombatState.Battle == CombatEnum.s_currentCombatState)
        {
            ExecuteBattleOrder();
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

            GetComponent<CombatUIController>().SetupNameTexts(m_party);
            GetComponent<CombatUIController>().UpdateHpTexts(m_party);

            CombatEnum.s_currentCombatState = CombatEnum.CombatState.ActionSelect;
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

            for (int i = 0; i < m_party.Count; ++i)
            {
                m_battleOrder.Add(i + 1, m_party[i]);
            }

            for (int i = 0; i < m_enemies.Count; ++i)
            {
                m_battleOrder.Add(i + m_party.Count + 1, m_enemies[i]);
            }

            foreach (var item in m_battleOrder)
            {
                Debug.Log(item.Key + ": " + item.Value.GetComponent<CharacterAttributes>().Name);
            }
        }
        else
        {
            Debug.Log("Enemies strike first.");

            for (int i = 0; i < m_enemies.Count; ++i)
            {
                m_battleOrder.Add(i + 1, m_enemies[i]);
            }

            for (int i = 0; i < m_party.Count; ++i)
            {
                m_battleOrder.Add(i + m_enemies.Count + 1, m_party[i]);
            }

            foreach (var item in m_battleOrder)
            {
                Debug.Log(item.Key + ": " + item.Value.GetComponent<CharacterAttributes>().Name);
            }
        }
    }

    public void GenerateEnemies()
    {
        m_enemies = new List<GameObject>();

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

            m_enemies.Add(enemy);
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
        for (int i = 0; i < m_party.Count; ++i)
        {
            m_party[i].transform.position = GetComponent<GenerateGrids>().PartyGrid[i, 1];
        }
    }

    public void PositionEnemyOnGrid()
    {
        int k = 0;

        for (int i = 0; i < GetComponent<GenerateGrids>().RowEnemy; ++i)
        {
            for (int j = 0; j < GetComponent<GenerateGrids>().ColumnEnemy; ++j)
            {
                m_enemies[k].transform.position = GetComponent<GenerateGrids>().EnemyGrid[j, i];
                ++k;

                if (k >= m_enemies.Count) break;
            }
            if (k >= m_enemies.Count) break;
        }
    }

    public void ChangeActivePartyMember()
    {
        // shift previous character back
        if(m_currentChar != -1) m_party[m_currentChar].transform.position = GetComponent<GenerateGrids>().PartyGrid[m_currentChar, 1];

        m_currentChar++;

        // if current character is the last character, return to first character and start battle
        if(m_currentChar >= m_party.Count)
        {
            m_party[m_party.Count - 1].transform.position = GetComponent<GenerateGrids>().PartyGrid[m_party.Count - 1, 1];
            m_currentChar = 0;
            CombatEnum.s_currentCombatState = CombatEnum.CombatState.Battle;
            return;
        }
        m_party[m_currentChar].transform.position = GetComponent<GenerateGrids>().PartyGrid[m_currentChar, 0];
    }

    public void ExecuteBattleOrder()
    {
        foreach (var character in m_battleOrder)
        {
            character.Value.GetComponent<ActionController>().ExecuteAction();
        }
    }
}
