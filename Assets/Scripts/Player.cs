using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float m_speed = 5.0f;  
    [SerializeField]
    private int m_gil = 500;
    private bool m_isMoving;
    private Vector2 m_input;

    // Start is called before the first frame update
    void Start()
    {
      /*  m_movePoint.parent = null;        */

    }

    // Update is called once per frame
    void Update()
    {
        m_input.x = Input.GetAxisRaw("Horizontal");
        m_input.y = Input.GetAxisRaw("Vertical");

        this.GetComponent<Rigidbody2D>().velocity = m_input * m_speed;

        PlayerMenu();
    }

    void CombatEncounter()
    {
        if(SceneManager.GetActiveScene().buildIndex == 2)
        {
            if (Random.Range(1.0f, 100.0f) <= 1.1f)
            {
                Debug.Log("You have encountered an enemy!");
                // add scene for battle
                GameObject.Find("SceneManager").GetComponent<ScreenSystem>().GoToCombatScene();
            }
        }
    }

    public void PlayerMenu()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            GameObject.Find("SceneManager").GetComponent<ScreenSystem>().GoToPauseScreen();
        }
    }


    public bool ForceCombatEncounter()
    {
        return true;
    }

    public int getGil()
    {
        return m_gil;
    }

    public void setGil(int t_num)
    {
        m_gil += t_num;
    }
}
