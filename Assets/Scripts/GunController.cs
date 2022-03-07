using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject m_bullet;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(m_bullet, transform.position, Quaternion.identity);

            Vector2 mousePos = GetComponentInChildren<Camera>().ScreenToWorldPoint(Input.mousePosition);
            Vector2 pos = transform.position;
            Vector2 direction = (mousePos - pos).normalized;

            bullet.GetComponent<Rigidbody2D>().velocity = direction * 10.0f;
        }
    }
}
