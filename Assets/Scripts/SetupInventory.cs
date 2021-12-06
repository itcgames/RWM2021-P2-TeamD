using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetupInventory : MonoBehaviour
{
  
    public int playerID;
    // Start is called before the first frame update
    void Start()
    {
       
       
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable()
    {
        
        switch (playerID)
        {
            case 1:
                this.transform.GetChild(1).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.m_name1;
                break;

            case 2:
                this.transform.GetChild(1).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.m_name2;
                break;

            case 3:
                this.transform.GetChild(1).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.m_name3;
                break;

            case 4:
                this.transform.GetChild(1).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.m_name4;
                break;
        }
        
    }
}
