using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateGrids : MonoBehaviour
{
    private int m_column = 2;
    private int m_row = 4;

    private int m_columnEnemy = 3;
    private int m_rowEnemy = 3;

    public Vector3[,] EnemyGrid { get; private set; }

    public Vector3[,] PartyGrid { get; private set; }

    public int ColumnEnemy
    {
        get { return m_columnEnemy; }
    }
    public int RowEnemy
    {
        get { return m_rowEnemy; }
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreatePartyGrid()
    {
        Vector3 firstTile = new Vector3();
        firstTile.Set(0.5f, 0.6f, 0.0f);

        PartyGrid = new Vector3[m_row, m_column];

        for (int i = 0; i < m_row; ++i)
        {
            for (int j = 0; j < m_column; ++j)
            {
                PartyGrid[i, j].Set(firstTile.x + (0.22f * j), firstTile.y - (0.28f * i), -1.0f);
            }
        }
    }

    public void CreateEnemyGrid()
    {
        Vector3 firstTile = new Vector3();
        firstTile.Set(-0.90f, 0.5f, 0.0f);

        EnemyGrid = new Vector3[m_rowEnemy, m_columnEnemy];

        for (int i = 0; i < m_rowEnemy; ++i)
        {
            for (int j = 0; j < m_columnEnemy; ++j)
            {
                EnemyGrid[i, j].Set(firstTile.x + (0.34f * j), firstTile.y - (0.34f * i), -1.0f);
            }
        }
    }

    public Vector3[,] CreateEnemyGridTest()
    {
        Vector3 firstTile = new Vector3();
        firstTile.Set(-0.90f, 0.5f, 0.0f);

        Vector3[,] test = new Vector3[m_rowEnemy, m_columnEnemy];

        for (int i = 0; i < m_rowEnemy; ++i)
        {
            for (int j = 0; j < m_columnEnemy; ++j)
            {
                test[i, j].Set(firstTile.x + (0.34f * j), firstTile.y - (0.34f * i), -1.0f);
            }
        }

        return test;
    }
}
