using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class weaponDE : MonoBehaviour
{
    bool drop;
    bool upgrade;
    bool equip;
    int upgradeCost = 25;
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

    public bool Upgrade()
    {
        return upgrade;
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
    public void setUpgrade(bool t_b)
    {
        upgrade = t_b;
    }

    public void dropping(int i)
    {
        if (drop)
        {
            switch (i)
            {
                case 0:
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);
                    break;
                case 1:
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);

                    break;
                case 2:
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);

                    break;
                case 3:
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);

                    break;
                case 4:
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);

                    break;
                case 5:
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);

                    break;
                case 6:
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);

                    break;
                case 7:
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);

                    break;
                case 8:
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);

                    break;
                case 9:
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);

                    break;
                case 10:
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);

                    break;
                case 11:
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);

                    break;
                case 12:
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);

                    break;
                case 13:
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);

                    break;
                case 14:
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Name = "";
                    FindObjectOfType<InventorWeapon>().setNameBlank(i);

                    break;
                case 15:
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Name = "";
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
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Equip = false;


                    break;
                case 1:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Equip;
                    }

                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Equip = false;


                    break;
                case 2:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Equip = false;


                    break;
                case 3:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Equip = false;



                    break;
                case 4:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Equip = false;


                    break;
                case 5:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Equip = false;


                    break;
                case 6:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Equip = false;


                    break;
                case 7:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Equip = false;


                    break;
                case 8:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Equip = false;


                    break;
                case 9:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Equip = false;


                    break;
                case 10:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Equip = false;


                    break;
                case 11:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Equip = false;


                    break;
                case 12:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Equip = false;

                    break;
                case 13:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Equip = false;


                    break;
                case 14:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Equip = false;


                    break;
                case 15:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Name == " ")
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Equip = false;

                    }
                    else
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Equip = !FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Equip;
                    }
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Equip = false;



                    break;

            }
            FindObjectOfType<InventorWeapon>().Equiping(0, FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Equip);
            FindObjectOfType<InventorWeapon>().Equiping(1, FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Equip);
            FindObjectOfType<InventorWeapon>().Equiping(2, FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Equip);
            FindObjectOfType<InventorWeapon>().Equiping(3, FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Equip);
            FindObjectOfType<InventorWeapon>().Equiping(4, FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Equip);
            FindObjectOfType<InventorWeapon>().Equiping(5, FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Equip);
            FindObjectOfType<InventorWeapon>().Equiping(6, FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Equip);
            FindObjectOfType<InventorWeapon>().Equiping(7, FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Equip);
            FindObjectOfType<InventorWeapon>().Equiping(8, FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Equip);
            FindObjectOfType<InventorWeapon>().Equiping(9, FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Equip);
            FindObjectOfType<InventorWeapon>().Equiping(10, FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Equip);
            FindObjectOfType<InventorWeapon>().Equiping(11, FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Equip);
            FindObjectOfType<InventorWeapon>().Equiping(12, FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Equip);
            FindObjectOfType<InventorWeapon>().Equiping(13, FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Equip);
            FindObjectOfType<InventorWeapon>().Equiping(14, FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Equip);
            FindObjectOfType<InventorWeapon>().Equiping(15, FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Equip);
        }
    }
    public void Upgrading(int i)
    {
        if (upgrade)
        {

            int amount = 1;
                switch (i)
                {
                    case 0:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Name.Contains("+ 1"))
                    {
                        amount = 2;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Name.Contains("+ 2"))
                    {
                        amount = 3;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Name.Contains("+ 3"))
                    {
                        amount = 4;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Name.Contains("+ 4"))
                    {
                        upgradeCost = 50;
                        amount = 5;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Name.Contains("+ 5"))
                    {
                        amount = 6;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Name.Contains("+ 6"))
                    {
                        amount = 7;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Name.Contains("+ 7"))
                    {
                        amount = 8;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Name.Contains("+ 8"))
                    {
                        amount = 9;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Name.Contains("+ 9"))
                    {
                        amount = 10;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Name.Contains("+ 10"))
                    {
                        upgradeCost = 99999999;

                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_gil >= upgradeCost && FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Value != 0)
                    {
                        FindObjectOfType<InventorWeapon>().Upgrading(i, amount);
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_gil -= upgradeCost;
                    }

                    break;
                    case 1:

                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Name.Contains("+ 1") )
                    {
                        amount = 2;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Name.Contains("+ 2"))
                    {
                        amount = 3;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Name.Contains("+ 3"))
                    {
                        amount = 4;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Name.Contains("+ 4"))
                    {
                        upgradeCost = 50;
                        amount = 5;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Name.Contains("+ 5"))
                    {
                        amount = 6;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Name.Contains("+ 6"))
                    {
                        amount = 7;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Name.Contains("+ 7"))
                    {
                        amount = 8;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Name.Contains("+ 8"))
                    {
                        amount = 9;

                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Name.Contains("+ 9"))
                    {
                        amount = 10;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Name.Contains("+ 10"))
                    {
                        upgradeCost = 99999999;

                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_gil >= upgradeCost && FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Value != 0)
                    {
                        FindObjectOfType<InventorWeapon>().Upgrading(i, amount);
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_gil -= upgradeCost;
                    }
                    break;
                    case 2:

                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Name.Contains("+ 1"))
                    {
                        amount = 2;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Name.Contains("+ 2"))
                    {
                        amount = 3;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Name.Contains("+ 3"))
                    {
                        amount = 4;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Name.Contains("+ 4"))
                    {
                        upgradeCost = 50;
                        amount = 5;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Name.Contains("+ 5"))
                    {
                        amount = 6;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Name.Contains("+ 6"))
                    {
                        amount = 7;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Name.Contains("+ 7"))
                    {
                        amount = 8;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Name.Contains("+ 8"))
                    {
                        amount = 9;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Name.Contains("+ 9"))
                    {
                        amount = 10;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Name.Contains("+ 10"))
                    {
                        upgradeCost = 99999999;

                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_gil >= upgradeCost && FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Value != 0)
                    {
                        FindObjectOfType<InventorWeapon>().Upgrading(i, amount);
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_gil -= upgradeCost;
                    }

                    break;
                    case 3:

                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Name.Contains("+ 1"))
                    {
                        amount = 2;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Name.Contains("+ 2"))
                    {
                        amount = 3;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Name.Contains("+ 3"))
                    {
                        amount = 4;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Name.Contains("+ 4"))
                    {
                        upgradeCost = 50;
                        amount = 5;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Name.Contains("+ 5"))
                    {
                        amount = 6;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Name.Contains("+ 6"))
                    {
                        amount = 7;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Name.Contains("+ 7"))
                    {
                        amount = 8;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Name.Contains("+ 8"))
                    {
                        amount = 9;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Name.Contains("+ 9"))
                    {
                        amount = 10;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Name.Contains("+ 10"))
                    {
                        upgradeCost = 99999999;

                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_gil >= upgradeCost && FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Value != 0)
                    {
                        FindObjectOfType<InventorWeapon>().Upgrading(i, amount);
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_gil -= upgradeCost;

                    }
                    break;
                    case 4:

                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Name.Contains("+ 1"))
                    {
                        amount = 2;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Name.Contains("+ 2"))
                    {
                        amount = 3;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Name.Contains("+ 3"))
                    {
                        amount = 4;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Name.Contains("+ 4"))
                    {
                        upgradeCost = 50;
                        amount = 5;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Name.Contains("+ 5"))
                    {
                        amount = 6;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Name.Contains("+ 6"))
                    {
                        amount = 7;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Name.Contains("+ 7"))
                    {
                        amount = 8;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Name.Contains("+ 8"))
                    {
                        amount = 9;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Name.Contains("+ 9"))
                    {
                        amount = 10;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Name.Contains("+ 10"))
                    {
                        upgradeCost = 99999999;

                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_gil >= upgradeCost && FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Value != 0)
                    {
                        FindObjectOfType<InventorWeapon>().Upgrading(i, amount);
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_gil -= upgradeCost;

                    }
                    break;
                    case 5:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Name.Contains("+ 1"))
                    {
                        amount = 2;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Name.Contains("+ 2"))
                    {
                        amount = 3;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Name.Contains("+ 3"))
                    {
                        amount = 4;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Name.Contains("+ 4"))
                    {
                        upgradeCost = 50;
                        amount = 5;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Name.Contains("+ 5"))
                    {
                        amount = 6;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Name.Contains("+ 6"))
                    {
                        amount = 7;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Name.Contains("+ 7"))
                    {
                        amount = 8;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Name.Contains("+ 8"))
                    {
                        amount = 9;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Name.Contains("+ 9"))
                    {
                        
                        amount = 10;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Name.Contains("+ 10"))
                    {
                        upgradeCost = 99999999;

                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_gil >= upgradeCost && FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Value != 0)
                    {
                        FindObjectOfType<InventorWeapon>().Upgrading(i, amount);
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_gil -= upgradeCost;

                    }

                    break;
                    case 6:

                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Name.Contains("+ 1"))
                    {
                        amount = 2;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Name.Contains("+ 2"))
                    {
                        amount = 3;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Name.Contains("+ 3"))
                    {
                        amount = 4;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Name.Contains("+ 4"))
                    {
                        upgradeCost = 50;
                        amount = 5;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Name.Contains("+ 5"))
                    {
                        amount = 6;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Name.Contains("+ 6"))
                    {
                        amount = 7;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Name.Contains("+ 7"))
                    {
                        amount = 8;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Name.Contains("+ 8"))
                    {
                        amount = 9;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Name.Contains("+ 9"))
                    {
                        amount = 10;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Name.Contains("+ 10"))
                    {
                        upgradeCost = 99999999;

                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_gil >= upgradeCost && FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Value != 0)
                    {
                        FindObjectOfType<InventorWeapon>().Upgrading(i, amount);
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_gil -= upgradeCost;

                    }
                    break;
                    case 7:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Name.Contains("+ 1"))
                    {
                        amount = 2;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Name.Contains("+ 2"))
                    {
                        amount = 3;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Name.Contains("+ 3"))
                    {
                        amount = 4;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Name.Contains("+ 4"))
                    {
                        upgradeCost = 50;
                        amount = 5;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Name.Contains("+ 5"))
                    {
                        amount = 6;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Name.Contains("+ 6"))
                    {
                        amount = 7;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Name.Contains("+ 7"))
                    {
                        amount = 8;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Name.Contains("+ 8"))
                    {
                        amount = 9;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Name.Contains("+ 9"))
                    {
                        amount = 10;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Name.Contains("+ 10"))
                    {
                        upgradeCost = 99999999;

                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_gil >= upgradeCost && FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Value != 0)
                    {
                        FindObjectOfType<InventorWeapon>().Upgrading(i, amount);
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_gil -= upgradeCost;

                    }
                    break;
                    case 8:

                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Name.Contains("+ 1"))
                    {
                        amount = 2;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Name.Contains("+ 2"))
                    {
                        amount = 3;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Name.Contains("+ 3"))
                    {
                        amount = 4;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Name.Contains("+ 4"))
                    {
                        upgradeCost = 50;
                        amount = 5;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Name.Contains("+ 5"))
                    {
                        amount = 6;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Name.Contains("+ 6"))
                    {
                        amount = 7;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Name.Contains("+ 7"))
                    {
                        amount = 8;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Name.Contains("+ 8"))
                    {
                        amount = 9;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Name.Contains("+ 9"))
                    {
                        amount = 10;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Name.Contains("+ 10"))
                    {
                        upgradeCost = 99999999;

                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_gil >= upgradeCost && FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Value != 0)
                    {
                        FindObjectOfType<InventorWeapon>().Upgrading(i, amount);
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_gil -= upgradeCost;

                    }
                    break;
                    case 9:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Name.Contains("+ 1"))
                    {
                        amount = 2;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Name.Contains("+ 2"))
                    {
                        amount = 3;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Name.Contains("+ 3"))
                    {
                        amount = 4;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Name.Contains("+ 4"))
                    {
                        upgradeCost = 50;
                        amount = 5;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Name.Contains("+ 5"))
                    {
                        amount = 6;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Name.Contains("+ 6"))
                    {
                        amount = 7;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Name.Contains("+ 7"))
                    {
                        amount = 8;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Name.Contains("+ 8"))
                    {
                        amount = 9;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Name.Contains("+ 9"))
                    {
                        amount = 10;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Name.Contains("+ 10"))
                    {
                        upgradeCost = 99999999;

                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_gil >= upgradeCost && FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Value != 0)
                    {
                        FindObjectOfType<InventorWeapon>().Upgrading(i, amount);
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_gil -= upgradeCost;

                    }

                    break;
                    case 10:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Name.Contains("+ 1"))
                    {
                        amount = 2;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Name.Contains("+ 2"))
                    {
                        amount = 3;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Name.Contains("+ 3"))
                    {
                        amount = 4;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Name.Contains("+ 4"))
                    {
                        upgradeCost = 50;
                        amount = 5;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Name.Contains("+ 5"))
                    {
                        amount = 6;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Name.Contains("+ 6"))
                    {
                        amount = 7;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Name.Contains("+ 7"))
                    {
                        amount = 8;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Name.Contains("+ 8"))
                    { 
                        amount = 9;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Name.Contains("+ 9"))
                    {
                        amount = 10;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Name.Contains("+ 10"))
                    {
                        upgradeCost = 99999999;

                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_gil >= upgradeCost && FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Value != 0)
                    {
                        FindObjectOfType<InventorWeapon>().Upgrading(i, amount);
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_gil -= upgradeCost;

                    }
                    break;
                    case 11:

                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Name.Contains("+ 1"))
                    {
                        amount = 2;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Name.Contains("+ 2"))
                    {
                        amount = 3;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Name.Contains("+ 3"))
                    {
                        amount = 4;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Name.Contains("+ 4"))
                    {
                        upgradeCost = 50;
                        amount = 5;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Name.Contains("+ 5"))
                    {
                        amount = 6;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Name.Contains("+ 6"))
                    {
                        amount = 7;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Name.Contains("+ 7"))
                    {
                        amount = 8;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Name.Contains("+ 8"))
                    {
                        amount = 9;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Name.Contains("+ 9"))
                    {
                        amount = 10;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Name.Contains("+ 10"))
                    {
                        upgradeCost = 99999999;

                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_gil >= upgradeCost && FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Value != 0)
                    {
                        FindObjectOfType<InventorWeapon>().Upgrading(i, amount);
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_gil -= upgradeCost;

                    }
                    break;
                    case 12:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Name.Contains("+ 1"))
                    {
                        amount = 2;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Name.Contains("+ 2"))
                    {
                        amount = 3;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Name.Contains("+ 3"))
                    {
                        amount = 4;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Name.Contains("+ 4"))
                    {
                        upgradeCost = 50;
                        amount = 5;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Name.Contains("+ 5"))
                    {
                        amount = 6;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Name.Contains("+ 6"))
                    {
                        amount = 7;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Name.Contains("+ 7"))
                    {
                        amount = 8;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Name.Contains("+ 8"))
                    {
                        amount = 9;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Name.Contains("+ 9"))
                    {
                        amount = 10;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Name.Contains("+ 10"))
                    {
                        upgradeCost = 99999999;

                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_gil >= upgradeCost && FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Value != 0)
                    {
                        FindObjectOfType<InventorWeapon>().Upgrading(i, amount);
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_gil -= upgradeCost;

                    }

                    break;
                    case 13:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Name.Contains("+ 1"))
                    {
                        amount = 2;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Name.Contains("+ 2"))
                    {
                        amount = 3;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Name.Contains("+ 3"))
                    {
                        amount = 4;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Name.Contains("+ 4"))
                    {
                        upgradeCost = 50;
                        amount = 5;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Name.Contains("+ 5"))
                    {
                        amount = 6;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Name.Contains("+ 6"))
                    {
                        amount = 7;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Name.Contains("+ 7"))
                    {
                        amount = 8;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Name.Contains("+ 8"))
                    {
                        amount = 9;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Name.Contains("+ 9"))
                    {
                        amount = 10;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Name.Contains("+ 10"))
                    {
                        upgradeCost = 99999999;

                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_gil >= upgradeCost && FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Value != 0)
                    {
                        FindObjectOfType<InventorWeapon>().Upgrading(i, amount);
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_gil -= upgradeCost;

                    }

                    break;
                    case 14:
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Name.Contains("+ 1"))
                    {
                        amount = 2;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Name.Contains("+ 2"))
                    {
                        amount = 3;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Name.Contains("+ 3"))
                    {
                        amount = 4;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Name.Contains("+ 4"))
                    {
                        upgradeCost = 50;
                        amount = 5;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Name.Contains("+ 5"))
                    {
                        amount = 6;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Name.Contains("+ 6"))
                    {
                        amount = 7;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Name.Contains("+ 7"))
                    {
                        amount = 8;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Name.Contains("+ 8"))
                    {
                        amount = 9;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Name.Contains("+ 9"))
                    {
                        amount = 10;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Name.Contains("+ 10"))
                    {
                        upgradeCost = 99999999;

                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_gil >= upgradeCost && FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Value != 0)
                    {
                        FindObjectOfType<InventorWeapon>().Upgrading(i, amount);
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_gil -= upgradeCost;

                    }
                    break;
                    case 15:

                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Name.Contains("+ 1"))
                    {
                        amount = 2;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Name.Contains("+ 2"))
                    {
                        amount = 3;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Name.Contains("+ 3"))
                    {
                        amount = 4;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Name.Contains("+ 4"))
                    {
                        upgradeCost = 50;
                        amount = 5;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Name.Contains("+ 5"))
                    {
                        amount = 6;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Name.Contains("+ 6"))
                    {
                        amount = 7;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Name.Contains("+ 7"))
                    {
                        amount = 8;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Name.Contains("+ 8"))
                    {
                        amount = 9;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Name.Contains("+ 9"))
                    {
                        amount = 10;
                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Name.Contains("+ 10"))
                    {
                        upgradeCost = 99999999;

                    }
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.m_gil >= upgradeCost && FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Value != 0)
                    {
                        FindObjectOfType<InventorWeapon>().Upgrading(i, amount);
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_gil -= upgradeCost;

                    }
                    break;

                }
               
        }
         upgradeCost = 25;
    }
}

