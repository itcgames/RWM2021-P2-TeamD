using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatCursorController : MonoBehaviour
{
    public GameObject m_cursor;

    public bool DecideAction { get; set; } = false;
    public bool ChoosePartyChar { get; set; } = false;
    public bool ChooseEnemyTarget { get; set; } = false;

    private Vector3[,] m_actionSelectGrid;
    private const int m_actionGridRow = 4;
    private const int m_actionGridCol = 2;

    private Vector3[] m_partyCharSelectGrid;
    private const int m_partyCharGridRow = 4;

    private Vector3[,] m_targetSelectGrid;
    private const int m_targetGridRowCol = 3;

    private int m_currentRow;
    private int m_currentCol;

    private int m_currentMaxRow;
    private int m_currentMaxCol;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetupCursor()
    {
        m_actionSelectGrid = new Vector3[m_actionGridRow, m_actionGridCol]
        {
            { new Vector3(-0.15f, -0.54f, 0), new Vector3(0.32f, -0.54f, 0),  },
            { new Vector3(-0.15f, -0.69f, 0), new Vector3(0.32f, -0.69f, 0),  },
            { new Vector3(-0.15f, -0.80f, 0), new Vector3(0.32f, -0.80f, 0),  },
            { new Vector3(-0.15f, -0.94f, 0), new Vector3(0.32f, -0.94f, 0),  },
        };

        m_partyCharSelectGrid = new Vector3[m_partyCharGridRow]
        {
            new Vector3(0.5f, 0.5f, 0),
            new Vector3(0.5f, 0.2f, 0),
            new Vector3(0.5f, -0.05f, 0),
            new Vector3(0.5f, -0.3f, 0),
        };

        m_targetSelectGrid = new Vector3[m_targetGridRowCol, m_targetGridRowCol]
        {
            { new Vector3(-1.15f, 0.5f, 0), new Vector3(-0.8f, 0.5f, 0), new Vector3(-0.45f, 0.5f, 0), },
            { new Vector3(-1.15f, 0.15f, 0), new Vector3(-0.8f, 0.15f, 0), new Vector3(-0.45f, 0.15f, 0), },
            { new Vector3(-1.15f, -0.2f, 0), new Vector3(-0.8f, -0.2f, 0), new Vector3(-0.45f, -0.2f, 0), },
        };
    }

    public void EnterActionSelect()
    {
        DecideAction = true;
        ChoosePartyChar = false;
        ChooseEnemyTarget = false;

        m_currentRow = 0;
        m_currentCol = 0;

        m_currentMaxRow = m_actionGridRow;
        m_currentMaxCol = m_actionGridCol;

        m_cursor.transform.position = m_actionSelectGrid[m_currentRow, m_currentCol];
    }

    public void EnterPartyCharSelect()
    {
        DecideAction = false;
        ChoosePartyChar = true;
        ChooseEnemyTarget = false;

        m_currentRow = 0;
        m_currentCol = 0;

        m_currentMaxRow = m_partyCharGridRow;
        m_currentMaxCol = 0;

        m_cursor.transform.position = m_partyCharSelectGrid[m_currentRow];
    }

    public void EnterTargetSelect()
    {
        DecideAction = false;
        ChoosePartyChar = false;
        ChooseEnemyTarget = true;

        m_currentRow = 0;
        m_currentCol = 0;

        m_currentMaxRow = m_targetGridRowCol;
        m_currentMaxCol = m_targetGridRowCol;

        m_cursor.transform.position = m_targetSelectGrid[m_currentRow, m_currentCol];
    }

    public void MoveRow(int amount)
    {
        if (m_currentRow + amount >= m_currentMaxRow) m_currentRow = m_currentMaxRow - 1;
        else if (m_currentRow + amount < 0) m_currentRow = 0;
        else m_currentRow += amount;

        if (DecideAction) m_cursor.transform.position = m_actionSelectGrid[m_currentRow, m_currentCol];
        else if (ChoosePartyChar) m_cursor.transform.position = m_partyCharSelectGrid[m_currentRow];
        else if (ChooseEnemyTarget) m_cursor.transform.position = m_targetSelectGrid[m_currentRow, m_currentCol];
    }

    public void MoveCol(int amount)
    {

        if (m_currentCol + amount >= m_currentMaxCol) m_currentCol = m_currentMaxCol - 1;
        else if (m_currentCol + amount < 0) m_currentCol = 0;
        else m_currentCol += amount;

        if (DecideAction) m_cursor.transform.position = m_actionSelectGrid[m_currentRow, m_currentCol];
        else if (ChoosePartyChar) m_cursor.transform.position = m_partyCharSelectGrid[m_currentRow];
        else if (ChooseEnemyTarget) m_cursor.transform.position = m_targetSelectGrid[m_currentRow, m_currentCol];
    }

    public void ChooseAction(int partyMemberIndex)
    {
        // Attack
        if (m_currentRow == 0 && m_currentCol == 0)
        {
            EnterTargetSelect();
        }

        // Flee
        else if (m_currentRow == 0 && m_currentCol == 1)
        {
            GetComponent<CombatController>().Party[partyMemberIndex].GetComponent<ActionController>().Action = ActionController.CombatAction.Flee;
            GetComponent<CombatController>().ChangeActivePartyMember();
        }

        // Magic
        else if (m_currentRow == 1 && m_currentCol == 0)
        {
            Debug.Log("Magic");
        }

        // Drink
        else if (m_currentRow == 2 && m_currentCol == 0)
        {
            Debug.Log("Drink");
        }

        // Item
        else if (m_currentRow == 3 && m_currentCol == 0)
        {
            Debug.Log("Item");
        }

        else
        {
            Debug.Log("Nothing");
        }
    }

    public void ChooseTarget(int partyMemberIndex)
    {
        GetComponent<CombatController>().Party[partyMemberIndex].GetComponent<ActionController>().Action = ActionController.CombatAction.Fight;
        GetComponent<CombatController>().Party[partyMemberIndex].GetComponent<ActionController>().Target = GetTarget();
        GetComponent<CombatController>().ChangeActivePartyMember();
        EnterActionSelect();
    }

    public GameObject GetTarget()
    {
        if (m_currentRow == 0 && m_currentCol == 0)
        {
            return GetComponent<CombatController>().EnemyList[0];
        }

        if (m_currentRow == 1 && m_currentCol == 0)
        {
            if (GetComponent<CombatController>().EnemyList.Count >= 1)
            {
                return GetComponent<CombatController>().EnemyList[1];
            }
        }

        if (m_currentRow == 2 && m_currentCol == 0)
        {
            if (GetComponent<CombatController>().EnemyList.Count >= 2)
            {
                return GetComponent<CombatController>().EnemyList[2];
            }
        }

        if (m_currentRow == 0 && m_currentCol == 1)
        {
            if (GetComponent<CombatController>().EnemyList.Count >= 3)
            {
                return GetComponent<CombatController>().EnemyList[3];
            }
        }

        if (m_currentRow == 1 && m_currentCol == 1)
        {
            if (GetComponent<CombatController>().EnemyList.Count >= 4)
            {
                return GetComponent<CombatController>().EnemyList[4];
            }
        }

        if (m_currentRow == 2 && m_currentCol == 1)
        {
            if (GetComponent<CombatController>().EnemyList.Count >= 5)
            {
                return GetComponent<CombatController>().EnemyList[5];
            }
        }

        if (m_currentRow == 0 && m_currentCol == 2)
        {
            if (GetComponent<CombatController>().EnemyList.Count >= 6)
            {
                return GetComponent<CombatController>().EnemyList[6];
            }
        }

        if (m_currentRow == 1 && m_currentCol == 2)
        {
            if (GetComponent<CombatController>().EnemyList.Count >= 7)
            {
                return GetComponent<CombatController>().EnemyList[7];
            }
        }

        if (m_currentRow == 2 && m_currentCol == 2)
        {
            if (GetComponent<CombatController>().EnemyList.Count >= 8)
            {
                return GetComponent<CombatController>().EnemyList[8];
            }
        }

        return null;
    }
}
