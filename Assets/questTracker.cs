using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class questTracker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.GetChild(0).GetComponent<Text>().text = "1: Head to the nearest town and beat the raiding bandits";
        this.transform.GetChild(1).GetComponent<Text>().text = "2: Head to the lake and beat the dessert warriors";
        this.transform.GetChild(2).GetComponent<Text>().text = "3: Head to the south town and beat the ninjas";
        this.transform.GetChild(3).GetComponent<Text>().text = "4: Gain access to the bridge";



    }

    // Update is called once per frame
    void Update()
    {
        if(FindObjectOfType<PlayerAndGameInfo>().infos.quest1Finished == true)
        {
            this.transform.GetChild(0).GetComponent<Text>().color = Color.green;
        }
        if (FindObjectOfType<PlayerAndGameInfo>().infos.quest2Finished == true)
        {
            this.transform.GetChild(1).GetComponent<Text>().color = Color.green;
        }
        if (FindObjectOfType<PlayerAndGameInfo>().infos.quest3Finished == true)
        {
            this.transform.GetChild(2).GetComponent<Text>().color = Color.green;
        }
        if (FindObjectOfType<PlayerAndGameInfo>().infos.quest3Finished == true && FindObjectOfType<PlayerAndGameInfo>().infos.quest2Finished == true && FindObjectOfType<PlayerAndGameInfo>().infos.quest1Finished == true)
        {
            this.transform.GetChild(3).GetComponent<Text>().color = Color.green;
        }
    }
}
