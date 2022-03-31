using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class weaponDE : MonoBehaviour
{
    bool drop;
    bool trade;
    bool equip;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_1.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);
                    break;
                case 1:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_2.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);

                    break;
                case 2:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_3.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);

                    break;
                case 3:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_4.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);

                    break;
                case 4:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_1.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);

                    break;
                case 5:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_2.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);

                    break;
                case 6:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_3.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);

                    break;
                case 7:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_4.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);

                    break;
                case 8:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_1.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);

                    break;
                case 9:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_2.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);

                    break;
                case 10:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_3.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);

                    break;
                case 11:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_4.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);

                    break;
                case 12:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_1.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);

                    break;
                case 13:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_2.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);

                    break;
                case 14:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_3.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);

                    break;
                case 15:
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_4.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);

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
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_1.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_1.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_1.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_1.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_2.Equip = false;


                    break;
                case 1:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_2.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_2.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_2.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_2.Equip;
                    }

                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_1.Equip = false;


                    break;
                case 2:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_3.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_3.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_3.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_3.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_1.Equip = false;


                    break;
                case 3:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_4.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_4.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_4.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_4.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_1.Equip = false;



                    break;
                case 4:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_1.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_1.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_1.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_1.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_4.Equip = false;


                    break;
                case 5:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_2.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_2.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_2.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_2.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_1.Equip = false;


                    break;
                case 6:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_3.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_3.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_3.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_3.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_1.Equip = false;


                    break;
                case 7:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_4.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_4.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_4.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_4.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_1.Equip = false;


                    break;
                case 8:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_1.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_1.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_1.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_1.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_4.Equip = false;


                    break;
                case 9:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_2.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_2.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_2.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_2.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_1.Equip = false;


                    break;
                case 10:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_3.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_3.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_3.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_3.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_1.Equip = false;


                    break;
                case 11:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_4.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_4.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_4.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_4.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_1.Equip = false;


                    break;
                case 12:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_1.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_1.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_1.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_1.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_4.Equip = false;

                    break;
                case 13:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_2.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_2.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_2.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_2.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_1.Equip = false;


                    break;
                case 14:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_3.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_3.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_3.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_3.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_1.Equip = false;


                    break;
                case 15:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_4.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_4.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_4.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_4.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_1.Equip = false;



                    break;

            }
            FindObjectOfType<InventorWeapon>().Equiping(0, FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_1.Equip);
            FindObjectOfType<InventorWeapon>().Equiping(1, FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_2.Equip);
            FindObjectOfType<InventorWeapon>().Equiping(2, FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_3.Equip);
            FindObjectOfType<InventorWeapon>().Equiping(3, FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_4.Equip);
            FindObjectOfType<InventorWeapon>().Equiping(4, FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_1.Equip);
            FindObjectOfType<InventorWeapon>().Equiping(5, FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_2.Equip);
            FindObjectOfType<InventorWeapon>().Equiping(6, FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_3.Equip);
            FindObjectOfType<InventorWeapon>().Equiping(7, FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_4.Equip);
            FindObjectOfType<InventorWeapon>().Equiping(8, FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_1.Equip);
            FindObjectOfType<InventorWeapon>().Equiping(9, FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_2.Equip);
            FindObjectOfType<InventorWeapon>().Equiping(10, FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_3.Equip);
            FindObjectOfType<InventorWeapon>().Equiping(11, FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_4.Equip);
            FindObjectOfType<InventorWeapon>().Equiping(12, FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_1.Equip);
            FindObjectOfType<InventorWeapon>().Equiping(13, FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_2.Equip);
            FindObjectOfType<InventorWeapon>().Equiping(14, FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_3.Equip);
            FindObjectOfType<InventorWeapon>().Equiping(15, FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_4.Equip);
        }
    }
    public void Trading(int i)
    {

    }
}
