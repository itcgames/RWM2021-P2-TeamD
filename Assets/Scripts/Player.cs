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
    public bool m_hasCollided;

    // Start is called before the first frame update
    void Start()
    {
      /*  m_movePoint.parent = null;        */

    }

    // Update is called once per frame
    void Update()
    {
        m_input.x = Input.GetAxisRaw("Horizontal");

        if(m_input.x > 0)
        {
            this.transform.localScale = new Vector3(0.5f, this.transform.localScale.y, this.transform.localScale.z);
        }
        if (m_input.x < 0)
        {
            this.transform.localScale = new Vector3(-0.5f, this.transform.localScale.y, this.transform.localScale.z);
        }
        m_input.y = Input.GetAxisRaw("Vertical");

        this.GetComponent<Rigidbody2D>().velocity = m_input * m_speed;

        PlayerMenu();
    }

    IEnumerator Move(Vector3 t_targetPos)
    {
        //CombatEncounter();

        m_isMoving = true;
        if ((t_targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, t_targetPos, m_speed * Time.deltaTime);
            yield return new WaitForSeconds(0.05f);
        }
        transform.position = t_targetPos;
        m_isMoving = false;
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
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            FindObjectOfType<PlayerAndGameInfo>().infos.player_pos = transform.position;
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Fence" || collision.gameObject.name == "Boulder"
            || collision.gameObject.name == "River")
        {
            m_hasCollided = true;
            Debug.Log("has collided with " + collision.gameObject.name);

        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("no Collision");
        m_hasCollided = false;
    }


    public bool getCollisionCheck()
    {
        return m_hasCollided;
    }
}
