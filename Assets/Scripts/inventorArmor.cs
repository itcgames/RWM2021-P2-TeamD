﻿using System.Collections;
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
        for (int i = 0; i <= 3; i++)
        {
            FindObjectOfType<PlayerAndGameInfo>().infos.character[i].m_armor1.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.character[i].m_armor1.Equip);
            FindObjectOfType<PlayerAndGameInfo>().infos.character[i].m_armor2.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.character[i].m_armor2.Equip);
            FindObjectOfType<PlayerAndGameInfo>().infos.character[i].m_armor3.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.character[i].m_armor3.Equip);
            FindObjectOfType<PlayerAndGameInfo>().infos.character[i].m_armor4.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.character[i].m_armor4.Equip);
        }


        this.transform.GetChild(0).transform.GetChild(0).GetChild(0).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor1.Name;
        this.transform.GetChild(0).transform.GetChild(0).GetChild(1).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor2.Name;
        this.transform.GetChild(0).transform.GetChild(0).GetChild(2).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor3.Name;
        this.transform.GetChild(0).transform.GetChild(0).GetChild(3).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor4.Name;
        this.transform.GetChild(1).transform.GetChild(0).GetChild(0).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor1.Name;
        this.transform.GetChild(1).transform.GetChild(0).GetChild(1).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor2.Name;
        this.transform.GetChild(1).transform.GetChild(0).GetChild(2).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor3.Name;
        this.transform.GetChild(1).transform.GetChild(0).GetChild(3).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor4.Name;
        this.transform.GetChild(2).transform.GetChild(0).GetChild(0).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor1.Name;
        this.transform.GetChild(2).transform.GetChild(0).GetChild(1).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor2.Name;
        this.transform.GetChild(2).transform.GetChild(0).GetChild(2).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor3.Name;
        this.transform.GetChild(2).transform.GetChild(0).GetChild(3).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor4.Name;
        this.transform.GetChild(3).transform.GetChild(0).GetChild(0).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[4].m_armor1.Name;
        this.transform.GetChild(3).transform.GetChild(0).GetChild(1).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[4].m_armor2.Name;
        this.transform.GetChild(3).transform.GetChild(0).GetChild(2).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[4].m_armor3.Name;
        this.transform.GetChild(3).transform.GetChild(0).GetChild(3).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[4].m_armor4.Name;

        
    }
    private void OnEnable()
    {



        this.transform.GetChild(0).transform.GetChild(0).GetChild(0).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor1.Name;
        this.transform.GetChild(0).transform.GetChild(0).GetChild(1).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor2.Name;
        this.transform.GetChild(0).transform.GetChild(0).GetChild(2).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor3.Name;
        this.transform.GetChild(0).transform.GetChild(0).GetChild(3).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor4.Name;
        this.transform.GetChild(1).transform.GetChild(0).GetChild(0).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor1.Name;
        this.transform.GetChild(1).transform.GetChild(0).GetChild(1).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor2.Name;
        this.transform.GetChild(1).transform.GetChild(0).GetChild(2).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor3.Name;
        this.transform.GetChild(1).transform.GetChild(0).GetChild(3).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor4.Name;
        this.transform.GetChild(2).transform.GetChild(0).GetChild(0).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor1.Name;
        this.transform.GetChild(2).transform.GetChild(0).GetChild(1).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor2.Name;
        this.transform.GetChild(2).transform.GetChild(0).GetChild(2).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor3.Name;
        this.transform.GetChild(2).transform.GetChild(0).GetChild(3).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor4.Name;
        this.transform.GetChild(3).transform.GetChild(0).GetChild(0).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor1.Name;
        this.transform.GetChild(3).transform.GetChild(0).GetChild(1).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor2.Name;
        this.transform.GetChild(3).transform.GetChild(0).GetChild(2).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor3.Name;
        this.transform.GetChild(3).transform.GetChild(0).GetChild(3).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor4.Name;

    }

    public void setNameBlank(int i)
    {
        
            switch (i)
            {
                case 0:

                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor1.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor1.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor1.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_attributeArmor.Value = 0;

                break;
                case 1:

                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor2.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor2.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor2.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_attributeArmor.Value = 0;

                break;
                case 2:
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor3.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor3.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor3.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_attributeArmor.Value = 0;

                break;
                case 3:
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor4.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor4.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor4.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_attributeArmor.Value = 0;

                break;
                case 4:
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor1.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor1.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor1.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_attributeArmor.Value = 0;

                break;
                case 5:
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor2.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor2.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor2.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_attributeArmor.Value = 0;

                break;
                case 6:
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor3.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor3.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor3.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_attributeArmor.Value = 0;

                break;
                case 7:
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor4.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor4.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor4.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_attributeArmor.Value = 0;

                break;
                case 8:
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor1.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor1.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor1.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_attributeArmor.Value = 0;

                break;
                case 9:
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor2.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor2.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor2.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_attributeArmor.Value = 0;

                break;
                case 10:
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor3.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor3.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor3.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_attributeArmor.Value = 0;

                break;
                case 11:
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor4.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor4.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor4.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_attributeArmor.Value = 0;

                break;
                case 12:
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor1.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor1.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor1.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_attributeArmor.Value = 0;

                break;
                case 13:
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor2.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor2.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor2.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_attributeArmor.Value = 0;

                break;
                case 14:
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor3.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor3.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor3.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_attributeArmor.Value = 0;

                break;
                case 15:
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor4.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor4.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor4.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_attributeArmor.Value = 0;
                break;


        }
       
        
    }
    public void Equiping(int i, bool equipped)
    {
        
            switch (i)
            {
                case 0:

                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor1.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor1.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor1.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor1.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_attributeArmor.Value = defense1 + FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor1.Value;
                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor1.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor1.Name == " "))
                        {

                            FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor1.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor1.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_attributeArmor.Value = defense1;

                        }
                    }

                    break;
                case 1:
                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor2.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor2.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor2.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor2.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_attributeArmor.Value = defense1 + FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor2.Value;

                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor2.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor2.Name == " "))
                        {
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor2.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor2.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_attributeArmor.Value = defense1;


                        }
                    }

                    break;
                case 2:
                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor3.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor3.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor3.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor3.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_attributeArmor.Value = defense1 + FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor3.Value;

                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor3.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor3.Name == " "))
                        {
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor3.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor3.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_attributeArmor.Value = defense1;

                        }
                    }
                    break;
                case 3:
                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor4.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor4.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor4.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor4.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_attributeArmor.Value = defense1 + FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor4.Value;

                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor4.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor4.Name == " "))
                        {
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor4.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_armor4.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_attributeArmor.Value = defense1;

                        }
                    }

                    break;
                case 4:
                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor1.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor1.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor1.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor1.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_attributeArmor.Value = defense2 + FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor1.Value;

                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor1.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor1.Name == " "))
                        {
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor1.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor1.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_attributeArmor.Value = defense2;

                        }
                    }
                    break;
                case 5:
                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor2.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor2.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor2.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor2.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_attributeArmor.Value = defense2 + FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor2.Value;

                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor2.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor2.Name == " "))
                        {
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor2.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor2.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_attributeArmor.Value = defense2;

                        }
                    }

                    break;
                case 6:
                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor3.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor3.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor3.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor3.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_attributeArmor.Value = defense2 + FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor3.Value;

                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor3.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor3.Name == " "))
                        {
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor3.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor3.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_attributeArmor.Value = defense2;

                        }
                    }

                    break;
                case 7:
                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor4.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor4.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor4.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor4.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_attributeArmor.Value = defense2 + FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor4.Value;

                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor4.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor4.Name == " "))
                        {
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor4.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_armor4.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_attributeArmor.Value = defense2;

                        }
                    }
                    break;
                case 8:
                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor1.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor1.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor1.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor1.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_attributeArmor.Value = defense3 + FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor1.Value;

                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor1.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor1.Name == " "))
                        {
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor1.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor1.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_attributeArmor.Value = defense3;

                        }
                    }

                    break;
                case 9:
                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor2.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor2.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor2.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor2.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_attributeArmor.Value = defense3 + FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor2.Value;

                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor2.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor2.Name == " "))
                        {
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor2.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor2.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_attributeArmor.Value = defense3;

                        }
                    }

                    break;
                case 10:
                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor3.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor3.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor3.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor3.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_attributeArmor.Value = defense3 + FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor3.Value;

                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor3.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor3.Name == " "))
                        {
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor3.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor3.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_attributeArmor.Value = defense3;

                        }
                    }
                    break;
                case 11:
                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor4.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor4.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor4.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor4.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_attributeArmor.Value = defense3 + FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor4.Value;

                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor4.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor4.Name == " "))
                        {
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor4.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_armor4.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_attributeArmor.Value = defense3;

                        }
                    }
                    break;
                case 12:
                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor1.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor1.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor1.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor1.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_attributeArmor.Value = defense4 + FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor1.Value;

                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor1.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor1.Name == " "))
                        {
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor1.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor1.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_attributeArmor.Value = defense4;

                        }
                    }
                    break;
                case 13:
                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor2.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor2.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor2.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor2.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_attributeArmor.Value = defense4 + FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor2.Value;

                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor2.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor2.Name == " "))
                        {
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor2.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor2.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_attributeArmor.Value = defense4;

                        }
                    }

                    break;
                case 14:
                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor3.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor3.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor3.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor3.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_attributeArmor.Value = defense4 + FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor3.Value;

                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor3.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor3.Name == " "))
                        {
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor3.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor3.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_attributeArmor.Value = defense4;

                        }
                    }

                    break;
                case 15:
                    if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor4.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor4.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor4.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor4.Name;
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_attributeArmor.Value = defense4 + FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor4.Value;


                    }
                    else if (!equipped)
                    {
                        if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor4.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor4.Name == " "))
                        {
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor4.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_armor4.Name.Remove(0, 2);
                            FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_attributeArmor.Value = defense4;

                        }
                    }

                    break;
            }
        }
    }



