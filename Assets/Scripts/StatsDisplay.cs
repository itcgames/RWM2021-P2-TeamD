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
    PlayerAndGameInfo.GameData info;

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

        nameText.text = info.character[current_char].m_name;
        levelText.text = "L " + info.character[current_char].m_lvl;
        healthText.text = "HP \n\t" + info.character[current_char].m_attributeHP.Value + " / " + info.character[current_char].m_attributeHPMax.Value;
        charImage.sprite = info.character[current_char].m_charImage;
        defenseText.text = "Defense " + info.character[current_char].m_attributeArmor.Value;
        attackText.text = "W.DMG " + info.character[current_char].m_attributeAttack.Value;
        damageText.text = "Damage " + info.character[current_char].m_attributeDam.Value;

    }
}
