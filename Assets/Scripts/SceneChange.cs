using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public int m_scene;
    public Animator m_animator;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if(/*m_scene != 2*/ SceneManager.GetActiveScene().buildIndex == 2 && FindObjectOfType<PlayerAndGameInfo>()!=null)
                FindObjectOfType<PlayerAndGameInfo>().infos.player_pos = (collision.gameObject.transform.position - new Vector3(0f, 0.4f, 0f));

            StartCoroutine("LoadLevel");
        }
    }
    IEnumerator LoadLevel()
    {
        m_animator.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        if (m_scene != 2 || FindObjectOfType<ScreenSystem>() == null)
            SceneManager.LoadScene(m_scene);
        else
        {
            FindObjectOfType<ScreenSystem>().GoToGameplayScene();
        }
    }

    public bool Faded()
    {

        m_animator.SetTrigger("Start");
        bool check = true;
        return check;
    }
    public void ExitGame()
    {
        Application.Quit();
    }

}
