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
            StartCoroutine("LoadLevel");
        }
    }
    IEnumerator LoadLevel()
    {
        m_animator.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(m_scene);
    }

    public bool Faded()
    {

        m_animator.SetTrigger("Start");
        bool check = true;
        return check;
    }

}
