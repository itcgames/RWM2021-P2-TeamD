using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DropTradeEquip : MonoBehaviour
{
    bool drop = false;
    bool trade = false;
    bool equip = false;
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
        switch(i)
        {
            case 0:
                FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Name = "";
                FindObjectOfType<inventorArmor>().setNameBlank(0);
                break;
            case 1:
                FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Name = "";
                FindObjectOfType<inventorArmor>().setNameBlank(1);

                break;
            case 2:
                FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3.Name = "";
                FindObjectOfType<inventorArmor>().setNameBlank(2);

                break;
            case 3:
                FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4.Name = "";
                FindObjectOfType<inventorArmor>().setNameBlank(3);

                break;
            case 4:
                FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Name = "";
                FindObjectOfType<inventorArmor>().setNameBlank(4);

                break;
            case 5:
                FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Name = "";
                FindObjectOfType<inventorArmor>().setNameBlank(i);

                break;
            case 6:
                FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3.Name = "";
                FindObjectOfType<inventorArmor>().setNameBlank(i);

                break;
            case 7:
                FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4.Name = "";
                FindObjectOfType<inventorArmor>().setNameBlank(i);

                break;
            case 8:
                FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Name = "";
                FindObjectOfType<inventorArmor>().setNameBlank(i);

                break;
            case 9:
                FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Name = "";
                FindObjectOfType<inventorArmor>().setNameBlank(i);

                break;
            case 10:
                FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3.Name = "";
                FindObjectOfType<inventorArmor>().setNameBlank(i);

                break;
            case 11:
                FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4.Name = "";
                FindObjectOfType<inventorArmor>().setNameBlank(i);

                break;
            case 12:
                FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Name = "";
                FindObjectOfType<inventorArmor>().setNameBlank(i);

                break;
            case 13:
                FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Name = "";
                FindObjectOfType<inventorArmor>().setNameBlank(i);

                break;
            case 14:
                FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3.Name = "";
                FindObjectOfType<inventorArmor>().setNameBlank(i);

                break;
            case 15:
                FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4.Name = "";
                FindObjectOfType<inventorArmor>().setNameBlank(i);

                break;
         
        }
       
    }
    public void Equiping(int i)
    {

    }
    public void Trading(int i)
    {

    }
}
