using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeOrb : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(FindObjectOfType<PlayerAndGameInfo>().infos.quest1Finished)
        {
            this.transform.GetChild(0).GetComponent<Image>().color = new Color(1, 0.5f, 0);
        }
        if (FindObjectOfType<PlayerAndGameInfo>().infos.quest2Finished)
        {
            this.transform.GetChild(1).GetComponent<Image>().color = Color.red;
        }
        if (FindObjectOfType<PlayerAndGameInfo>().infos.quest3Finished)
        {
            this.transform.GetChild(2).GetComponent<Image>().color = new Color(255, 165,0);
        }
        if (FindObjectOfType<PlayerAndGameInfo>().infos.quest4Finished)
        {
            this.transform.GetChild(3).GetComponent<Image>().color = Color.black;
        }
    }
}
