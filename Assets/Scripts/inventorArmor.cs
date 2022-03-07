using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class inventorArmor : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        


        this.transform.GetChild(0).transform.GetChild(0).GetChild(0).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Name;
        this.transform.GetChild(0).transform.GetChild(0).GetChild(1).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Name;
        this.transform.GetChild(0).transform.GetChild(0).GetChild(2).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Name;
        this.transform.GetChild(0).transform.GetChild(0).GetChild(3).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Name;
        this.transform.GetChild(1).transform.GetChild(0).GetChild(0).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Name;
        this.transform.GetChild(1).transform.GetChild(0).GetChild(1).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Name;
        this.transform.GetChild(1).transform.GetChild(0).GetChild(2).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Name;
        this.transform.GetChild(1).transform.GetChild(0).GetChild(3).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Name;
        this.transform.GetChild(2).transform.GetChild(0).GetChild(0).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Name;
        this.transform.GetChild(2).transform.GetChild(0).GetChild(1).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Name;
        this.transform.GetChild(2).transform.GetChild(0).GetChild(2).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Name;
        this.transform.GetChild(2).transform.GetChild(0).GetChild(3).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Name;
        this.transform.GetChild(3).transform.GetChild(0).GetChild(0).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Name;
        this.transform.GetChild(3).transform.GetChild(0).GetChild(1).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Name;
        this.transform.GetChild(3).transform.GetChild(0).GetChild(2).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Name;
        this.transform.GetChild(3).transform.GetChild(0).GetChild(3).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Name;
      
    }

    public void setNameBlank(int i)
    {
        switch (i)
        {
            case 0:
            this.transform.GetChild(0).transform.GetChild(0).GetChild(0).GetComponent<Text>().text = "";


                break;
            case 1:
                this.transform.GetChild(0).transform.GetChild(0).GetChild(1).GetComponent<Text>().text = "";

                break;
            case 2:
                this.transform.GetChild(0).transform.GetChild(0).GetChild(2).GetComponent<Text>().text = "";

                break;
            case 3:
                this.transform.GetChild(0).transform.GetChild(0).GetChild(3).GetComponent<Text>().text = "";

                break;
            case 4:
                this.transform.GetChild(1).transform.GetChild(0).GetChild(0).GetComponent<Text>().text = "";

                break;
            case 5:
                this.transform.GetChild(1).transform.GetChild(0).GetChild(1).GetComponent<Text>().text ="";

                break;
            case 6:
                this.transform.GetChild(1).transform.GetChild(0).GetChild(2).GetComponent<Text>().text = "";

                break;
            case 7:
                this.transform.GetChild(1).transform.GetChild(0).GetChild(3).GetComponent<Text>().text = "";

                break;
            case 8:
                this.transform.GetChild(2).transform.GetChild(0).GetChild(0).GetComponent<Text>().text = "";

                break;
            case 9:
                this.transform.GetChild(2).transform.GetChild(0).GetChild(1).GetComponent<Text>().text = "";

                break;
            case 10:
                this.transform.GetChild(2).transform.GetChild(0).GetChild(2).GetComponent<Text>().text = "";

                break;
            case 11:
                this.transform.GetChild(2).transform.GetChild(0).GetChild(3).GetComponent<Text>().text = "";

                break;
            case 12:
                this.transform.GetChild(3).transform.GetChild(0).GetChild(0).GetComponent<Text>().text = "";

                break;
            case 13:
                this.transform.GetChild(3).transform.GetChild(0).GetChild(1).GetComponent<Text>().text = "";

                break;
            case 14:
                this.transform.GetChild(3).transform.GetChild(0).GetChild(2).GetComponent<Text>().text = "";

                break;
            case 15:
                this.transform.GetChild(3).transform.GetChild(0).GetChild(3).GetComponent<Text>().text = "";

                break;

        }
    }

}
