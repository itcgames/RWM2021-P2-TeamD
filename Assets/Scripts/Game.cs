using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public bool m_isGameOver;

    [SerializeField]
    private GameObject m_playerModel;

    private static Game m_gameInstance;
    int m_sceneNum;

    // Start is called before the first frame update
    private void Start()
    {
        int m_sceneNum = SceneManager.GetActiveScene().buildIndex;
        m_gameInstance = this;
    }

    // Creates a new game for testing purposes
    public void NewGame()
    {
        m_isGameOver = false;
        int m_sceneNum = SceneManager.GetActiveScene().buildIndex;
    }

    public Player getPlayerModel()
    {
        return m_playerModel.GetComponent<Player>();
    }

    public int GetActiveIndex()
    {
        return m_sceneNum;
    }

    public bool CheckPlayer()
    {
        GameObject m_player;
        if(m_player = GameObject.FindGameObjectWithTag("Player"))
        {
            return true;
        }
        else
        {
            return false;
        }

    }

}
