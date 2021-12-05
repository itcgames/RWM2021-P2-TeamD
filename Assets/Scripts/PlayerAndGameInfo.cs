using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAndGameInfo : MonoBehaviour
{
    [System.Serializable]
    public class CharacterInfo
    {
        public int m_gil = 400;
        public int m_currentScene = 2;
        public string m_name1;
        public Sprite m_charImage1;
        public Attribute m_attributeHP1;
        public Attribute m_attributeDam1;
        public string m_name2;
        public Sprite m_charImage2;
        public Attribute m_attributeHP2;
        public Attribute m_attributeDam2;
        public string m_name3;
        public Sprite m_charImage3;
        public Attribute m_attributeHP3;
        public Attribute m_attributeDam3;
        public string m_name4;
        public Sprite m_charImage4;
        public Attribute m_attributeHP4;
        public Attribute m_attributeDam4;
    }


    public CharacterInfo infos;

    // Start is called before the first frame update
    void Start()
    {
        infos = new CharacterInfo();

        DontDestroyOnLoad(this);
    }

    public void SetCharacter(int charNum, string name, Sprite sprite, Attribute attributeHP, Attribute attributeDam )
    {
        if(charNum == 1)
        {
            infos.m_name1 = name;
            infos.m_charImage1 = sprite;
            infos.m_attributeHP1 = attributeHP;
            infos.m_attributeDam1 = attributeDam;
        }
        else if (charNum == 2)
        {
            infos.m_name2 = name;
            infos.m_charImage2 = sprite;
            infos.m_attributeHP2 = attributeHP;
            infos.m_attributeDam2 = attributeDam;
        }
        else if (charNum == 3)
        {
            infos.m_name3 = name;
            infos.m_charImage3 = sprite;
            infos.m_attributeHP3 = attributeHP;
            infos.m_attributeDam3 = attributeDam;
        }
        else if (charNum == 4)
        {
            infos.m_name4 = name;
            infos.m_charImage4 = sprite;
            infos.m_attributeHP4 = attributeHP;
            infos.m_attributeDam4 = attributeDam;
        }
    }

    public CharacterInfo GetCharInfo()
    {
        return infos;
    }
}
