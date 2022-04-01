using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsDisplay : MonoBehaviour
{
    public int current_char;

    Image charImage;
    Text nameText;
    Text levelText;
    Text healthText;
    Text defenseText;
    Text attackText;
    Text damageText;
    PlayerAndGameInfo.CharacterInfo info;

    void Start()
    {
        nameText = transform.GetChild(0).GetComponent<Text>();
        levelText = transform.GetChild(1).GetComponent<Text>();
        healthText = transform.GetChild(2).GetComponent<Text>();
        charImage = transform.GetChild(3).GetComponent<Image>();
        defenseText = transform.GetChild(4).GetComponent<Text>();
        attackText = transform.GetChild(5).GetComponent<Text>();
        damageText = transform.GetChild(6).GetComponent<Text>();
        info = FindObjectOfType<PlayerAndGameInfo>().GetCharInfo();


    }

    public void Update()
    {

        info = FindObjectOfType<PlayerAndGameInfo>().GetCharInfo();

        if (current_char == 0)
        {
            nameText.text = info.m_name1;
            levelText.text = "L " + info.m_lvl1;
            healthText.text = "HP \n\t" + info.m_attributeHP1.Value + " / " + info.m_attributeHPMax1.Value;
            charImage.sprite = info.m_charImage1;
            defenseText.text = "Defense " + info.m_attributeArmor1.Value;
            attackText.text = "W.DMG " + info.m_attributeAttack1.Value;
            damageText.text = "Damage " + info.m_attributeDam1.Value;
        }
        else if (current_char == 1)
        {
            nameText.text = info.m_name2;
            levelText.text = "L " + info.m_lvl2;
            healthText.text = "HP \n\t" + info.m_attributeHP2.Value + " / " + info.m_attributeHPMax2.Value;
            charImage.sprite = info.m_charImage2;
            defenseText.text = "Defense " + info.m_attributeArmor2.Value;
            attackText.text = "W.DMG " + info.m_attributeAttack2.Value;
            damageText.text = "Damage " + info.m_attributeDam2.Value;
        }
        else if (current_char == 2)
        {
            nameText.text = info.m_name3;
            levelText.text = "L " + info.m_lvl3;
            healthText.text = "HP \n\t" + info.m_attributeHP3.Value + " / " + info.m_attributeHPMax3.Value;
            charImage.sprite = info.m_charImage3;
            defenseText.text = "Defense " + info.m_attributeArmor3.Value;
            attackText.text = "W.DMG " + info.m_attributeAttack3.Value;
            damageText.text = "Damage " + info.m_attributeDam3.Value;
        }
        else if (current_char == 3)
        {
            nameText.text = info.m_name4;
            levelText.text = "L " + info.m_lvl4;
            healthText.text = "HP \n\t" + info.m_attributeHP4.Value + " / " + info.m_attributeHPMax4.Value;
            charImage.sprite = info.m_charImage4;
            defenseText.text = "Defense " + info.m_attributeArmor4.Value;
            attackText.text = "W.DMG " + info.m_attributeAttack4.Value;
            damageText.text = "Damage " + info.m_attributeDam4.Value;
        }
    }
}
