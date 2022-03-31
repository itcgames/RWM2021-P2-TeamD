using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DropTradeEquip : MonoBehaviour
{
    bool drop ;
    bool trade;
    bool equip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(drop && this.CompareTag("drop"))
        {
            this.GetComponentInChildren<Text>().GetComponentInChildren<Text>().color = Color.green;
        }
        if (equip && this.CompareTag("equip"))
        {
            this.GetComponentInChildren<Text>().GetComponentInChildren<Text>().color = Color.green;

        }
        if (equip && this.CompareTag("drop"))
        {
            this.GetComponentInChildren<Text>().GetComponentInChildren<Text>().color = Color.gray;

        }
        if (drop && this.CompareTag("equip"))
        {
            this.GetComponentInChildren<Text>().GetComponentInChildren<Text>().color = Color.grey;
        }
    }
   public bool Drop()
    {
        return drop;
    }

    public bool Trade()
    {
        return trade;
    }
    public bool Equip()
    {
        return equip;
    }

    public void setEquip(bool t_b)
    {
        equip = t_b;
    }
    public void setDrop(bool t_b)
    {
        drop = t_b;
    }
    public void setTrade(bool t_b)
    {
        trade = t_b;
    }

    public void dropping(int i)
    {
        if (drop)
        {
            switch (i)
            {
                case 0:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Name = " ";
                    FindObjectOfType<inventorArmor>().setNameBlank(i);
                    break;
                case 1:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Name = " ";
                    FindObjectOfType<inventorArmor>().setNameBlank(i);

                    break;
                case 2:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Name = " ";
                    FindObjectOfType<inventorArmor>().setNameBlank(i);

                    break;
                case 3:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Name = " ";
                    FindObjectOfType<inventorArmor>().setNameBlank(i);

                    break;
                case 4:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Name = " ";
                    FindObjectOfType<inventorArmor>().setNameBlank(i);

                    break;
                case 5:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Name = " ";
                    FindObjectOfType<inventorArmor>().setNameBlank(i);

                    break;
                case 6:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Name = " ";
                    FindObjectOfType<inventorArmor>().setNameBlank(i);

                    break;
                case 7:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Name = " ";
                    FindObjectOfType<inventorArmor>().setNameBlank(i);

                    break;
                case 8:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Name = " ";
                    FindObjectOfType<inventorArmor>().setNameBlank(i);

                    break;
                case 9:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Name = " ";
                    FindObjectOfType<inventorArmor>().setNameBlank(i);

                    break;
                case 10:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Name = " ";
                    FindObjectOfType<inventorArmor>().setNameBlank(i);

                    break;
                case 11:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Name = " ";
                    FindObjectOfType<inventorArmor>().setNameBlank(i);

                    break;
                case 12:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Name = " ";
                    FindObjectOfType<inventorArmor>().setNameBlank(i);

                    break;
                case 13:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Name = " ";
                    FindObjectOfType<inventorArmor>().setNameBlank(i);

                    break;
                case 14:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Name = " ";
                    FindObjectOfType<inventorArmor>().setNameBlank(i);

                    break;
                case 15:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Name = " ";
                    FindObjectOfType<inventorArmor>().setNameBlank(i);

                    break;

            }
        }
    }
    public void Equiping(int i)
    {
        if (equip)
        {
            switch (i)
            {
                case 0:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Equip; }
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Equip = false;


                    break;
                case 1:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Equip; }

                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Equip = false;


                    break;
                case 2:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Equip; }
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Equip = false;


                    break;
                case 3:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Equip; }
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Equip = false;



                    break;
                case 4:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Equip; }
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Equip = false;


                    break;
                case 5:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Equip; }
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Equip = false;


                    break;
                case 6:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Equip; }
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Equip = false;


                    break;
                case 7:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Equip; }
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Equip = false;


                    break;
                case 8:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Equip; }
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Equip = false;


                    break;
                case 9:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Equip; }
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Equip = false;


                    break;
                case 10:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Equip; }
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Equip = false;


                    break;
                case 11:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Equip; }
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Equip = false;


                    break;
                case 12:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Equip; }
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Equip = false;

                    break;
                case 13:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Equip; }
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Equip = false;


                    break;
                case 14:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Equip = false;


                    break;
                case 15:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Equip = false;



                    break;

            }
            FindObjectOfType<inventorArmor>().Equiping(0, FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Equip);
            FindObjectOfType<inventorArmor>().Equiping(1, FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Equip);
            FindObjectOfType<inventorArmor>().Equiping(2, FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Equip);
            FindObjectOfType<inventorArmor>().Equiping(3, FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Equip);
            FindObjectOfType<inventorArmor>().Equiping(4, FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Equip);
            FindObjectOfType<inventorArmor>().Equiping(5, FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Equip);
            FindObjectOfType<inventorArmor>().Equiping(6, FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Equip);
            FindObjectOfType<inventorArmor>().Equiping(7, FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Equip);
            FindObjectOfType<inventorArmor>().Equiping(8, FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Equip);
            FindObjectOfType<inventorArmor>().Equiping(9, FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Equip);
            FindObjectOfType<inventorArmor>().Equiping(10, FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Equip);
            FindObjectOfType<inventorArmor>().Equiping(11, FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Equip);
            FindObjectOfType<inventorArmor>().Equiping(12, FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Equip);
            FindObjectOfType<inventorArmor>().Equiping(13, FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Equip);
            FindObjectOfType<inventorArmor>().Equiping(14, FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Equip);
            FindObjectOfType<inventorArmor>().Equiping(15, FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Equip);
        }
    }
    public void Trading(int i)
    {

    }
}
