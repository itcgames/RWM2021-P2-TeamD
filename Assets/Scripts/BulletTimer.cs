using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTimer : MonoBehaviour
{
    private float m_timeToDie = 0.5f;

    // Update is called once per frame
    void Update()
    {
        m_timeToDie -= Time.deltaTime;

        if (m_timeToDie <= 0.0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy") && tag == "Player Bullet")
        {
            Debug.Log("You have encountered an enemy!");
            CombatEnum.s_advantage = true;
            // add scene for battle
            GameObject.Find("SceneManager").GetComponent<ScreenSystem>().GoToCombatScene();
        }

        else if (other.CompareTag("Player") && tag == "Enemy Bullet")
        {
            Debug.Log("You have encountered an enemy!");
            CombatEnum.s_advantage = false;
            // add scene for battle

            GameObject sceneManager = GameObject.Find("SceneManager");

            if (sceneManager != null)
            {
                sceneManager.GetComponent<ScreenSystem>().GoToCombatScene();
            }
        }
    }
}
