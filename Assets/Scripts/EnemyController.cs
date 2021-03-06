using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float initialShotDelay;
    private float shotCooldown;
    private bool m_readyToFire = false;
    public GameObject m_bullet;

    // Start is called before the first frame update
    void Start()
    {
        shotCooldown = initialShotDelay;
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<EnemyID>())
        {
            if (!EnemyUtil.s_enemyAliveStatus[GetComponent<EnemyID>().ID - 1])
            {
                Debug.Log("Enemy " + GetComponent<EnemyID>().ID + " inactive");
                gameObject.SetActive(false);
            }
        }

        if (shotCooldown >= 0.0f)
        {
            shotCooldown -= Time.deltaTime;
        }
        else if (shotCooldown <= 0.0f && !m_readyToFire)
        {
            m_readyToFire = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (m_readyToFire)
            {
                Fire(collision.transform.position);
            }
        }

    }

    public void Fire(Vector2 target)
    {
        GameObject bullet = Instantiate(m_bullet, transform.position, Quaternion.identity);

        bullet.SendMessage("SetID", GetComponent<EnemyID>().ID);

        Vector2 pos = transform.position;
        Vector2 direction = (target - pos).normalized;

        bullet.GetComponent<Rigidbody2D>().velocity = direction * 1.7f;

        m_readyToFire = false;
        shotCooldown = initialShotDelay;
    }
}
