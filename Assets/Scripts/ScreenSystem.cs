using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenSystem : MonoBehaviour
{
    int m_currentInventory = 0;
    bool m_switchToGameplay = true;

    private void Awake()
    {
        if (this.gameObject.name != "Canvas")
            DontDestroyOnLoad(this.gameObject);
        EnemyUtil.ResetEnemyStatus();
    }

    public void GoToCharacterSelcetionScene()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToGameplayScene()
    {
        m_switchToGameplay = true;
        SceneManager.LoadScene(2);
    }

    public void ContinueGame()
    {
        string infoString = FindObjectOfType<CheckpointSystem>().LoadData();
        JsonUtility.FromJsonOverwrite(infoString, FindObjectOfType<PlayerAndGameInfo>().infos);
        EnemyUtil.ResetEnemyStatus();
        GoToGameplayScene();
    }

    public void GoToPauseScreen()
    {
        SceneManager.LoadScene(3);
    }

    public void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 3)
        { 
            //if (Input.GetKeyDown(KeyCode.Return))
            //{
            //    GoToGameplayScene();
            //}
            if(Input.GetMouseButtonUp(1))
            {
                if (m_currentInventory != 0)
                    FindObjectOfType<Cursor>().GoBack();
                else
                    GoToGameplayScene();
            }
        }
        if (SceneManager.GetActiveScene().buildIndex == 2 && m_switchToGameplay)
        {
            GameObject.FindGameObjectWithTag("Player").transform.position = FindObjectOfType<PlayerAndGameInfo>().infos.player_pos;
            m_switchToGameplay = false;
        }

    }

    public void GoToInventoryScreen(int t_i)
    {
        m_currentInventory = t_i;

        if(this.gameObject != null)
            if(this.gameObject.name == "Canvas")
            {
                for (int i = 0; i < this.transform.childCount; i++)
                {
                    if(i < this.transform.childCount-2)
                        this.transform.GetChild(i).gameObject.SetActive(false);
                    //else
                       // this.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.SetActive(false);
                }
                this.transform.GetChild(t_i-1).gameObject.SetActive(true);
            }
    }

    public int GetCurrentInventory()
    {
        return m_currentInventory;
    }

    public void GoToScene(int t_i)
    {
        SceneManager.LoadScene(t_i);
    }

    public void LoadSaveAfterLose()
    {
        string infoString = FindObjectOfType<CheckpointSystem>().LoadData();
        JsonUtility.FromJsonOverwrite(infoString, FindObjectOfType<PlayerAndGameInfo>().infos);

        GoToScene(FindObjectOfType<PlayerAndGameInfo>().infos.m_currentScene);
    }

    public void GoToCombatScene()
    {
        FindObjectOfType<PlayerAndGameInfo>().infos.player_pos = GameObject.FindGameObjectWithTag("Player").transform.position;
        SceneManager.LoadScene(7);
    }

    public void EndpointHit()
    {
        SceneManager.LoadScene(13);
    }

    public void EndGame()
    {
        SceneManager.LoadScene(0);
    }

    public void WinGame()
    {
        SceneManager.LoadScene(14);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
