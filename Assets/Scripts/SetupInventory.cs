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
                this.transform.GetChild(1).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_name;
                break;

            case 2:
                this.transform.GetChild(1).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_name;
                break;

            case 3:
                this.transform.GetChild(1).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_name;
                break;

            case 4:
                this.transform.GetChild(1).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_name;
                break;
        }
        
    }
}
