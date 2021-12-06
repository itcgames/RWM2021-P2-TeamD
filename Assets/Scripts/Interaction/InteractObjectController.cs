using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractObjectController : MonoBehaviour
{
    private BoxCollider2D m_collider;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        m_collider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public bool CheckInteractCollisions()
    {
        if (m_collider.bounds.Contains(player.transform.position + (Vector3)player.GetComponent<InteractionController>().Direction))
        {
            if (gameObject.tag == "NPC")
            {
                player.GetComponent<InteractionController>().SetText("Hello Traveler.\nNeed something?");
                return true;
            }
            if (gameObject.tag == "Board")
            {
                player.GetComponent<InteractionController>().SetText("A board with quests\n posted by the\n villagers");
                return true;
            }
        }
        else player.GetComponent<InteractionController>().SetText("");
        return false;
    }
}
