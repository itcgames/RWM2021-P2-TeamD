using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class inventorArmor : MonoBehaviour
{
    private GameObject armour;
    public float mhp1;
    public float mhp2; 
    public float mhp3; 
    public float mhp4; 

    // Start is called before the first frame update
    void Start()
    {
        mhp1 = FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHPMax1.Value;
        mhp2 = FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHPMax2.Value;
        mhp2 = FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHPMax2.Value;
        mhp2 = FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHPMax2.Value;

    }

    // Update is called once per frame
    void Update()
    {
       
        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Equip);
        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Equip);
        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Equip);
        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Equip);
        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Equip);
        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Equip);
        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Equip);
        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Equip);
        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Equip);
        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Equip);
        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Equip);
        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Equip);
        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Equip);
        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Equip);
        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Equip);
        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Equip);


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
    public void Equiping(int i, bool equipped)
    {
      
        switch (i)
        {
            case 0:
                
                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Name.StartsWith("E:"))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHPMax1.Value = mhp1 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Value;
                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Name.StartsWith("E:"))
                    {

                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Name.Remove(0,2);
                     

                    }
                }

                break;
            case 1:
                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Name.StartsWith("E:"))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHPMax1.Value = mhp1 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Value;

                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Name.StartsWith("E:"))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Name.Remove(0,2);
                     

                    }
                }

                break;
            case 2:
                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Name.StartsWith("E:"))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHPMax1.Value = mhp1 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Value;

                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Name.StartsWith("E:"))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Name.Remove(0,2);

                    }
                }
                break;
            case 3:
                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Name.StartsWith("E:"))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHPMax1.Value = mhp1 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Value;

                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Name.StartsWith("E:"))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Name.Remove(0,2);

                    }
                }

                break;
            case 4:
                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Name.StartsWith("E:"))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHPMax2.Value = mhp2 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Value;

                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Name.StartsWith("E:"))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Name.Remove(0,2);

                    }
                }
                break;
            case 5:
                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Name.StartsWith("E:"))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHPMax2.Value = mhp2 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Value;

                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Name.StartsWith("E:"))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Name.Remove(0,2);

                    }
                }

                break;
            case 6:
                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Name.StartsWith("E:"))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHPMax2.Value = mhp2 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Value;

                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Name.StartsWith("E:"))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Name.Remove(0,2);

                    }
                }

                break;
            case 7:
                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Name.StartsWith("E:"))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHPMax2.Value = mhp2 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Value;

                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Name.StartsWith("E:"))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Name.Remove(0,2);

                    }
                }
                break;
            case 8:
                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Name.StartsWith("E:"))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHPMax3.Value = mhp3 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Value;

                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Name.StartsWith("E:"))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Name.Remove(0,2);

                    }
                }

                break;
            case 9:
                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Name.StartsWith("E:"))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHPMax3.Value = mhp3 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Value;

                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Name.StartsWith("E:"))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Name.Remove(0,2);

                    }
                }

                break;
            case 10:
                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Name.StartsWith("E:"))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHPMax3.Value = mhp3 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Value;

                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Name.StartsWith("E:"))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Name.Remove(0,2);

                    }
                }
                break;
            case 11:
                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Name.StartsWith("E:"))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHPMax3.Value = mhp3 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Value;

                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Name.StartsWith("E:"))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Name.Remove(0,2);

                    }
                }
                break;
            case 12:
                 if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Name.StartsWith("E:"))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHPMax4.Value = mhp4 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Value;

                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Name.StartsWith("E:"))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Name.Remove(0,2);

                    }
                }
                break;
            case 13:
                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Name.StartsWith("E:"))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHPMax4.Value = mhp4 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Value;

                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Name.StartsWith("E:"))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Name.Remove(0,2);

                    }
                }

                break;
            case 14:
                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Name.StartsWith("E:"))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHPMax4.Value = mhp4 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Value;

                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Name.StartsWith("E:"))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Name.Remove(0,2);

                    }
                }

                break;
            case 15:
                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Name.StartsWith("E:"))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHPMax4.Value = mhp4 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Value;
               

                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Name.StartsWith("E:"))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Name.Remove(0,2);

                    }
                }

                break;
        }
    }
}


