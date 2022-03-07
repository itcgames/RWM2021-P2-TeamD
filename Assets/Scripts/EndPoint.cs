using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPoint : MonoBehaviour
{
    private const int FIGHT_WINS_TO_END = 5;
    int fightsWon = 0;

    private void Awake()
    {
        if (this.gameObject.name != "Canvas")
            DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 2 || SceneManager.GetActiveScene().buildIndex == 7)
            this.gameObject.SetActive(true);
        else
            this.gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            FindObjectOfType<ScreenSystem>().EndpointHit();
    }

    public void FightWon()
    {
        fightsWon++;
        if(fightsWon >= FIGHT_WINS_TO_END)
        {
            FindObjectOfType<ScreenSystem>().EndpointHit();
        }
    }
}
