using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class inventorArmor : MonoBehaviour
{
    private GameObject armour;
    public float defense1;
    public float defense2; 
    public float defense3; 
    public float defense4; 

    // Start is called before the first frame update
    void Start()
    {
        defense1 =0;
        defense2 = 0;
        defense2 =0;
        defense2 = 0;

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

                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Name = " ";
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor1.Value = 0;


                break;
                case 1:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Name = " ";
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor1.Value = 0;

                break;
                case 2:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Name = " ";
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor1.Value = 0;

                break;
                case 3:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Name = " ";
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor1.Value = 0;

                break;
                case 4:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Name = " ";
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor2.Value = 0;

                break;
                case 5:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Name = " ";
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor2.Value = 0;

                break;
                case 6:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Name = " ";
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor2.Value = 0;

                break;
                case 7:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Name = " ";
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor2.Value = 0;

                break;
                case 8:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Name = " ";
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor3.Value = 0;

                break;
                case 9:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Name = " ";
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor3.Value = 0;

                break;
                case 10:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Name = " ";
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor3.Value = 0;

                break;
                case 11:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Name = " ";
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor3.Value = 0;

                break;
                case 12:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Name = " ";
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor4.Value = 0;

                break;
                case 13:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Name = " ";
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor4.Value = 0;

                break;
                case 14:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Name = " ";
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor4.Value = 0;

                break;
                case 15:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Name = " ";
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Value = 0;
                   FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor4.Value = 0; 
                    break;

            
        }
       

    }
    public void Equiping(int i, bool equipped)
    {
        
            switch (i)
            {
                case 0:

                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor1.Value = defense1 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Value;
                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Name == " "))
                        {

                            FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor1.Value = defense1;

                        }
                    }

                    break;
                case 1:
                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor1.Value = defense1 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Value;

                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Name == " "))
                        {
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor1.Value = defense1;


                        }
                    }

                    break;
                case 2:
                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor1.Value = defense1 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Value;

                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Name == " "))
                        {
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor1.Value = defense1;

                        }
                    }
                    break;
                case 3:
                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor1.Value = defense1 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Value;

                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Name == " "))
                        {
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor1.Value = defense1;

                        }
                    }

                    break;
                case 4:
                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor2.Value = defense2 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Value;

                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Name == " "))
                        {
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor2.Value = defense2;

                        }
                    }
                    break;
                case 5:
                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor2.Value = defense2 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Value;

                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Name == " "))
                        {
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor2.Value = defense2;

                        }
                    }

                    break;
                case 6:
                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor2.Value = defense2 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Value;

                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Name == " "))
                        {
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor2.Value = defense2;

                        }
                    }

                    break;
                case 7:
                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor2.Value = defense2 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Value;

                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Name == " "))
                        {
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor2.Value = defense2;

                        }
                    }
                    break;
                case 8:
                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor3.Value = defense3 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Value;

                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Name == " "))
                        {
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor3.Value = defense3;

                        }
                    }

                    break;
                case 9:
                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor3.Value = defense3 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Value;

                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Name == " "))
                        {
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor3.Value = defense3;

                        }
                    }

                    break;
                case 10:
                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor3.Value = defense3 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Value;

                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Name == " "))
                        {
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor3.Value = defense3;

                        }
                    }
                    break;
                case 11:
                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor3.Value = defense3 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Value;

                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Name == " "))
                        {
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor3.Value = defense3;

                        }
                    }
                    break;
                case 12:
                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor4.Value = defense4 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Value;

                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Name == " "))
                        {
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor4.Value = defense4;

                        }
                    }
                    break;
                case 13:
                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor4.Value = defense4 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Value;

                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Name == " "))
                        {
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor4.Value = defense4;

                        }
                    }

                    break;
                case 14:
                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor4.Value = defense4 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Value;

                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Name == " "))
                        {
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor4.Value = defense4;

                        }
                    }

                    break;
                case 15:
                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor4.Value = defense4 + FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Value;


                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Name == " "))
                        {
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Name = FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeArmor4.Value = defense4;

                        }
                    }

                    break;
            }
        }
    }



