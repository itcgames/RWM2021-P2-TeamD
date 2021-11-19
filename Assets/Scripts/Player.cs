using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float m_speed = 5.0f;
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
        if (!m_isMoving)
        {
            m_input.x = Input.GetAxisRaw("Horizontal");
            m_input.y = Input.GetAxisRaw("Vertical");

            if (m_input.x != 0) m_input.y = 0;

            if (m_input != Vector2.zero)
            {
                var m_targetPos = transform.position;
                m_targetPos.x += m_input.x / 32;
                m_targetPos.y += m_input.y / 32;

                StartCoroutine(Move(m_targetPos));
            }
        }
    }

    IEnumerator Move(Vector3 t_targetPos)
        {
            m_isMoving = true;
            while ((t_targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
            {
                transform.position = Vector3.MoveTowards(transform.position, t_targetPos, m_speed * Time.deltaTime);
                yield return null;
            }
            transform.position = t_targetPos;
            m_isMoving = false;
        }


        public void moveUp()
        {
            transform.Translate(Vector2.up * Time.deltaTime * 1000);
        }


}
