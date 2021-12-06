using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenSystem : MonoBehaviour
{
    int m_currentInventory = 0;

    private void Awake()
    {
        if (this.gameObject.name != "Canvas")
            DontDestroyOnLoad(this.gameObject);
    }

    public void GoToCharacterSelcetionScene()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToGameplayScene()
    {
        SceneManager.LoadScene(2);
    }

    public void ContinueGame()
    {
        string infoString = FindObjectOfType<CheckpointSystem>().LoadData();
        JsonUtility.FromJsonOverwrite(infoString, FindObjectOfType<PlayerAndGameInfo>().infos);
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
            if (Input.GetKeyDown(KeyCode.Return))
            {
                GoToGameplayScene();
            }
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
                    if(i < this.transform.childCount-1)
                        this.transform.GetChild(i).gameObject.SetActive(false);
                    else
                        this.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.SetActive(false);
                }
                this.transform.GetChild(t_i).gameObject.SetActive(true);
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
}
