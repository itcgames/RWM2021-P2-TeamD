using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionController : MonoBehaviour
{
    public Vector2 Direction { get; set; }
    public bool InInteractMode { get; set; } = false;

    private float m_length = 10.0f;
    private Text m_interactionText;

    public GameObject m_interactionBox;

    // Start is called before the first frame update
    void Start()
    {
        m_interactionText = m_interactionBox.GetComponentInChildren<Canvas>().GetComponentInChildren<Text>();
        m_interactionText.text = "";
        m_interactionBox.GetComponent<SpriteRenderer>().enabled = InInteractMode;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            m_interactionBox.transform.position = GetComponent<Player>().transform.position + new Vector3(0.0f, 0.5f);
            InInteractMode = !InInteractMode;
            m_interactionBox.GetComponent<SpriteRenderer>().enabled = InInteractMode;
            if (InInteractMode) m_interactionText.text = "";
        }
    }

    public void SetDirection(Vector2 vel)
    {
        Direction = vel.normalized * m_length;
    }
}
