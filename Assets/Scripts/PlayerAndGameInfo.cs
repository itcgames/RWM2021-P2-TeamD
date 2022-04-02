using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAndGameInfo : MonoBehaviour
{
    [System.Serializable]
    public class CharacterInfo
    {
        public string m_name;
        public Sprite m_charImage;
        public weapon m_weapon1 = new weapon(" ", 0, false);
        public weapon m_weapon2 = new weapon(" ", 0, false);
        public weapon m_weapon3 = new weapon(" ", 0, false);
        public weapon m_weapon4 = new weapon(" ", 0, false);
        public armor m_armor1 = new armor(" ", 0, false);
        public armor m_armor2 = new armor(" ", 0, false);
        public armor m_armor3 = new armor(" ", 0, false);
        public armor m_armor4 = new armor(" ", 0, false);
        public Attribute m_attributeHP;
        public Attribute m_attributeHPMax;
        public Attribute m_attributeDam;
        public Attribute m_attributeArmor = new Attribute("Defence", 0);
        public Attribute m_attributeAttack = new Attribute("Attack", 0);
        public int m_xp = 0;
        public int m_lvl = 1;
        public int m_lvlThreshold = 100;
        public int m_type;
    }

    [System.Serializable]
    public class GameData
    {
        public int m_gil = 400;
        public int m_currentScene = 2;
        public Vector2 player_pos = new Vector2(-0.75f, 2.5f);
        
        public List<CharacterInfo> character = new List<CharacterInfo>();

        public bool quest1Triggered = false;
        public bool quest1Finished = false;
        public bool quest2Triggered = false;
        public bool quest2Finished = false;
        public bool quest3Triggered = false;
        public bool quest3Finished = false;
        public bool quest4Triggered = false;
        public bool quest4Finished = false;
    }


    public GameData infos;
    public CheckpointSystem t_system;


    // Start is called before the first frame update
    void Start()
    {
        infos = new GameData();
        t_system = new CheckpointSystem();
        DontDestroyOnLoad(this);
    }

    public void SetCharacter(int charNum, string name, Sprite sprite, Attribute attributeHP, Attribute attributeDam, int type, Attribute attributeMHP)
    {
        CharacterInfo info = new CharacterInfo();

        info.m_name = name;
        info.m_charImage = sprite;
        info.m_attributeHP = attributeHP;
        info.m_attributeDam = attributeDam;
        info.m_type = type;
        info.m_attributeHPMax = attributeMHP;

        infos.character.Add(info);
    }

    public GameData GetCharInfo()
    {
        return infos;
    }

    public string JsonLoadString()
    {
        return "";
        //return t_system.LoadData().ToString();
    }
}
