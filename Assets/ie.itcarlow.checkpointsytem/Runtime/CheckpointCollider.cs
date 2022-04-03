using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckpointCollider : MonoBehaviour
{
    float checkpointHitTimer = 10.0f;
    public float currentCheckpointTime = 10.0f;
    public bool savePossible = true;
    public CheckpointSystem t_checkpointSystem;

    public bool displayDistance = true;
    public bool showVisually = true;
    public float distanceToDisplay = 10;
    public GameObject playerPos;
    float distance;
    public Text distanceText;

    void Awake()
    {
        if (FindObjectOfType<CheckpointSystem>() == null)
        {
            t_checkpointSystem = new CheckpointSystem();
        }
        else
        {
            t_checkpointSystem = FindObjectOfType<CheckpointSystem>();
        }

        playerPos = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if(!savePossible)
        {
            if(currentCheckpointTime > 0.0f)
            {
                currentCheckpointTime -= Time.deltaTime;
            }
            else
            {
                currentCheckpointTime = checkpointHitTimer;
                savePossible = true;
            }
        }

        if(displayDistance)
        {
            distance = Vector3.Magnitude(playerPos.transform.position - this.transform.position);
            if (distance <= distanceToDisplay)
            {
                distanceText.gameObject.SetActive(true);
                distanceText.text = distance.ToString() + " m";
            }
            else
            {
                distanceText.gameObject.SetActive(false);
            }
        }
        if(showVisually)
        {
            distance = Vector3.Magnitude(playerPos.transform.position - this.transform.position);
            if (distance <= distanceToDisplay)
            {
                this.GetComponent<SpriteRenderer>().enabled = true;
            }
            else
            {
                this.GetComponent<SpriteRenderer>().enabled = false;
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision && savePossible)
        {
            savePossible = false;
            if (t_checkpointSystem != null)
            {
                t_checkpointSystem.SaveDataToFile();
            }
            else
            {
                t_checkpointSystem = new CheckpointSystem();
                t_checkpointSystem.Awake();
                t_checkpointSystem.SaveDataToFile();
            }
        }
    }
}
