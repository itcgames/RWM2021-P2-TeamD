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
        //load saved info here
        GoToGameplayScene();
    }

    public void GoToPauseScreen()
    {
        SceneManager.LoadScene(3);
    }

    public void GoToInventoryScreen(int t_i)
    {
        m_currentInventory = t_i;

        if(this.gameObject != null)
            if(this.gameObject.name == "Canvas")
            {
                for (int i = 0; i < this.transform.childCount; i++)
                {
                    this.transform.GetChild(i).gameObject.SetActive(false);
                }
                this.transform.GetChild(t_i).gameObject.SetActive(true);
            }
    }

    public int GetCurrentInventory()
    {
        return m_currentInventory;
    }
}
