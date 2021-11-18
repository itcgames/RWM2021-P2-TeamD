using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenSystem : MonoBehaviour
{

    private void Awake()
    {
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
}
