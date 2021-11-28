using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatCursorController : MonoBehaviour
{
    public GameObject m_cursor;

    private bool m_decideAction = false;
    private bool m_choosePartyChar = false;
    private bool m_chooseEnemyTarget = false;

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

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnterActionSelect()
    {
        m_decideAction = true;
        m_choosePartyChar = false;
        m_chooseEnemyTarget = false;
        
        m_currentRow = 0;
        m_currentCol = 0;

        m_currentMaxRow = m_actionGridRow;
        m_currentMaxCol = m_actionGridCol;

        m_cursor.transform.position = m_actionSelectGrid[m_currentRow, m_currentCol];
    }

    public void EnterPartyCharSelect()
    {
        m_decideAction = false;
        m_choosePartyChar = true;
        m_chooseEnemyTarget = false;

        m_currentRow = 0;
        m_currentCol = 0;

        m_currentMaxRow = m_partyCharGridRow;
        m_currentMaxCol = 0;

        m_cursor.transform.position = m_partyCharSelectGrid[m_currentRow];
    }

    public void EnterTargetSelect()
    {
        m_decideAction = false;
        m_choosePartyChar = false;
        m_chooseEnemyTarget = true;

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

        if(m_decideAction) m_cursor.transform.position = m_actionSelectGrid[m_currentRow, m_currentCol];
        else if(m_choosePartyChar) m_cursor.transform.position = m_partyCharSelectGrid[m_currentRow];
        else if(m_chooseEnemyTarget) m_cursor.transform.position = m_targetSelectGrid[m_currentRow, m_currentCol];
    }

    public void MoveCol(int amount)
    {

        if (m_currentCol + amount >= m_currentMaxCol) m_currentCol = m_currentMaxCol - 1;
        else if (m_currentCol + amount < 0) m_currentCol = 0;
        else m_currentCol += amount;

        if (m_decideAction) m_cursor.transform.position = m_actionSelectGrid[m_currentRow, m_currentCol];
        else if (m_choosePartyChar) m_cursor.transform.position = m_partyCharSelectGrid[m_currentRow];
        else if (m_chooseEnemyTarget) m_cursor.transform.position = m_targetSelectGrid[m_currentRow, m_currentCol];
    }

    public void ChooseAction(int partyMemberIndex)
    {
        // Attack
        if (m_currentRow == 0 && m_currentCol == 0)
        {
            GetComponent<CombatController>().ChangeActivePartyMember();
        }

        // Flee
        else if (m_currentRow == 0 && m_currentCol == 1)
        {
            GetComponent<CombatController>().ChangeActivePartyMember();
        }

        // Magic
        else if(m_currentRow == 1 && m_currentCol == 0)
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
}
