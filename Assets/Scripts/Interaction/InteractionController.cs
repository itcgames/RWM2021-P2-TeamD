using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionController : MonoBehaviour
{
    public Vector2 Direction { get; set; }
    public bool InInteractMode { get; set; } = false;

    public string TextBuffer { get; set; } = "";

    private float m_length = 0.2f;
    private Text m_interactionText;

    public GameObject InteractionBox;
    public List<GameObject> Interactables;

    private bool isInteracted = false;

    // Start is called before the first frame update
    void Start()
    {
        m_interactionText = InteractionBox.GetComponentInChildren<Canvas>().GetComponentInChildren<Text>();
        m_interactionText.text = "";
        InteractionBox.GetComponent<SpriteRenderer>().enabled = InInteractMode;
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var interactable in Interactables)
        {
            isInteracted = interactable.GetComponent<InteractObjectController>().CheckInteractCollisions();
            if (isInteracted) break;
        }

        if (Input.GetKeyUp(KeyCode.Return))
        {
            InteractionBox.transform.position = GetComponent<Player>().transform.position + new Vector3(0.0f, 0.5f);
            InInteractMode = !InInteractMode;
            InteractionBox.GetComponent<SpriteRenderer>().enabled = InInteractMode;
            if (TextBuffer == "") TextBuffer = "Nothing.";

            if (!InInteractMode) m_interactionText.text = "";
            else m_interactionText.text = TextBuffer;
            isInteracted = false;
        }
    }

    public void SetDirection(Vector2 vel)
    {
        Direction = vel.normalized * m_length;
        Debug.Log(transform.position + (Vector3)Direction);
    }

    public void SetText(string text)
    {
        TextBuffer = text;
    }
}
