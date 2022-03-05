using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTimer : MonoBehaviour
{
    private float m_timeToDie = 4.0f;

    // Update is called once per frame
    void Update()
    {
        m_timeToDie -= Time.deltaTime;

        if(m_timeToDie <= 0.0f)
        {
            Destroy(gameObject);
        }
    }
}
