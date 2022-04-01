using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAndGameInfo : MonoBehaviour
{
    public class CharacterInfo
    {
        public int m_gil = 400;
        public int m_currentScene = 2;
        public Vector2 player_pos = new Vector2(-0.75f, 2.5f);
        public string m_name1;
        public Sprite m_charImage1;
        public weapon m_weapon1_1 = new weapon(" ", 0, false);
        public weapon m_weapon1_2 = new weapon(" ", 0, false);
        public weapon m_weapon1_3 = new weapon(" ", 0, false);
        public weapon m_weapon1_4 = new weapon(" ", 0, false);
        public armor m_armor1_1 = new armor(" ", 0, false);
        public armor m_armor1_2 = new armor(" ", 0, false);
        public armor m_armor1_3 = new armor(" ", 0, false);
        public armor m_armor1_4 = new armor(" ", 0, false);
        public Attribute m_attributeHP1;
        public Attribute m_attributeHPMax1;
        public Attribute m_attributeDam1;
        public Attribute m_attributeArmor1 = new Attribute("Defence", 0);
        public Attribute m_attributeAttack1 = new Attribute("Attack", 0);
        public int m_xp1 = 0;
        public int m_lvl1 = 1;
        public int m_lvlThreshold1 = 100;

        public int m_type1;
        public string m_name2;
        public Sprite m_charImage2;
        public weapon m_weapon2_1 = new weapon(" ", 0, false);
        public weapon m_weapon2_2 = new weapon(" ", 0, false);
        public weapon m_weapon2_3 = new weapon(" ", 0, false);
        public weapon m_weapon2_4 = new weapon(" ", 0, false);
        public armor m_armor2_1 = new armor(" ", 0, false);
        public armor m_armor2_2 = new armor(" ", 0, false);
        public armor m_armor2_3 = new armor(" ", 0, false);
        public armor m_armor2_4 = new armor(" ", 0, false);
        public Attribute m_attributeHP2;
        public Attribute m_attributeHPMax2;
        public int m_xp2 = 0;
        public int m_lvl2 = 1;
        public int m_lvlThreshold2 = 100;

        public Attribute m_attributeDam2;
        public Attribute m_attributeArmor2 =new Attribute("Defence",0);
        public Attribute m_attributeAttack2 = new Attribute("Attack", 0);


        public int m_type2;
        public string m_name3;
        public Sprite m_charImage3;
        public weapon m_weapon3_1 = new weapon(" ", 0, false);
        public weapon m_weapon3_2  = new weapon(" ", 0, false);
        public weapon m_weapon3_3 = new weapon(" ", 0, false);
        public weapon m_weapon3_4 = new weapon(" ", 0, false);
        public armor m_armor3_1 = new armor(" ",0, false);
        public armor m_armor3_2 = new armor(" ", 0, false);
        public armor m_armor3_3 = new armor(" ", 0, false);
        public armor m_armor3_4 = new armor(" ", 0, false);
        public Attribute m_attributeHP3;
        public Attribute m_attributeHPMax3;
        public int m_xp3 = 0;
        public int m_lvl3 = 1;
        public int m_lvlThreshold3 = 100;

        public Attribute m_attributeDam3;
        public Attribute m_attributeArmor3 =new Attribute("Defence",0);
        public Attribute m_attributeAttack3 = new Attribute("Attack", 0);

        public int m_type3;
        public string m_name4;
        public Sprite m_charImage4;
        public weapon m_weapon4_2 = new weapon(" ", 0, false);
        public weapon m_weapon4_1 = new weapon(" ", 0, false);
        public weapon m_weapon4_3 = new weapon(" ", 0, false);
        public weapon m_weapon4_4 = new weapon(" ", 0, false);
        public armor m_armor4_1 = new armor(" ", 0, false);
        public armor m_armor4_2 = new armor(" ", 0, false);
        public armor m_armor4_3 = new armor(" ", 0, false);
        public armor m_armor4_4 = new armor(" ", 0, false);
        public Attribute m_attributeHP4;
        public Attribute m_attributeHPMax4;
        public Attribute m_attributeArmor4 = new Attribute("Defence", 0);
        public Attribute m_attributeAttack4 = new Attribute("Attack", 0);
        public int m_xp4 = 0;
        public int m_lvl4 = 1;
        public int m_lvlThreshold4 = 100;


        public Attribute m_attributeDam4;
        public int m_type4;
        public bool quest1Triggered = false;
        public bool quest1Finished = false;
        public bool quest2Triggered = false;
        public bool quest2Finished = false;
        public bool quest3Triggered = false;
        public bool quest3Finished = false;
        public bool quest4Triggered = false;
        public bool quest4Finished = false;
    }


    public CharacterInfo infos;
    public CheckpointSystem t_system;


    // Start is called before the first frame update
    void Start()
    {
        infos = new CharacterInfo();
        t_system = new CheckpointSystem();
        DontDestroyOnLoad(this);
    }

    public void SetCharacter(int charNum, string name, Sprite sprite, Attribute attributeHP, Attribute attributeDam, int type, Attribute attributeMHP)
    {
        if(charNum == 1)
        {
            infos.m_name1 = name;
            infos.m_charImage1 = sprite;
            infos.m_attributeHP1 = attributeHP;
            infos.m_attributeDam1 = attributeDam;
            infos.m_type1 = type;
            infos.m_attributeHPMax1 = attributeMHP;
        }
        else if (charNum == 2)
        {
            infos.m_name2 = name;
            infos.m_charImage2 = sprite;
            infos.m_attributeHP2 = attributeHP;
            infos.m_attributeDam2 = attributeDam;
            infos.m_type2 = type;
            infos.m_attributeHPMax2 = attributeMHP;

        }
        else if (charNum == 3)
        {
            infos.m_name3 = name;
            infos.m_charImage3 = sprite;
            infos.m_attributeHP3 = attributeHP;
            infos.m_attributeDam3 = attributeDam;
            infos.m_type3 = type;
            infos.m_attributeHPMax3 = attributeMHP;

        }
        else if (charNum == 4)
        {
            infos.m_name4 = name;
            infos.m_charImage4 = sprite;
            infos.m_attributeHP4 = attributeHP;
            infos.m_attributeDam4 = attributeDam; 
            infos.m_type4 = type;
            infos.m_attributeHPMax4 = attributeMHP;

        }
    }

    public CharacterInfo GetCharInfo()
    {
        return infos;
    }

    public string JsonLoadString()
    {
        return t_system.LoadData().ToString();
    }
}
