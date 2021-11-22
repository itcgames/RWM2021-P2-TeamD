using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateGrids : MonoBehaviour
{
    public int column;
    public int row;

    private int m_columnEnemy;
    private int m_rowEnemy;

    private Vector3[,] m_partyGrid;
    private Vector3[,] m_enemyGrid;

    public Vector3[,] PartyGrid
    {
        get { return m_partyGrid; }
    }

    // Start is called before the first frame update
    void Start()
    {
        CreatePartyGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreatePartyGrid()
    {
        Vector3 firstTile = new Vector3();
        firstTile.Set(0.10f, 0.24f, 0.0f);

        m_partyGrid = new Vector3[row, column];

        for (int i = 0; i < row; ++i)
        {
            for (int j = 0; j < column; ++j)
            {
                m_partyGrid[row, column].Set(firstTile.x + (0.22f * i), firstTile.y - (0.24f * j), 0.0f);
            }
        }
    }
}
