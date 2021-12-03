using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicInvDisplay : MonoBehaviour
{
    Spells spells; //1 is the character number
    int spellLevel;
    const int childOffset = 1;
    int charSelected = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.AddComponent<Spells>();
        spells = this.gameObject.GetComponent<Spells>();

        spellLevel = 1;
        DisplayUses(spellLevel);
    }

    public void DisplayUses(int t_level)
    {
        spellLevel = t_level;
        string n = spells.UsesLeft().ToString() + "/" + spells.MaxUsesAmount().ToString();
        this.transform.GetChild(t_level + childOffset).Find("Uses").GetComponent<Text>().text = n;
    }

    public void DisplaySpells(int t_level)
    {
        spellLevel = t_level;
        string n = "";
        if (spells.GetBlackSpells().Count > 0 && spells.GetBlackSpells() != null)
        {
            int i = 0;
            while(spells.GetBlackSpells().Count > i)
            {
                n = spells.GetBlackSpells()[i].ToString();
                this.transform.GetChild(t_level + childOffset).Find("Spell"+ (i+1).ToString()).GetComponent<Text>().text = n;
                i++;
            }
        }
        else if (spells.GetWhiteSpells().Count > 0 && spells.GetWhiteSpells() != null)
        {
            int i = 0;
            while (spells.GetWhiteSpells().Count > i)
            {
                n = spells.GetWhiteSpells()[i].ToString();
                this.transform.GetChild(t_level + childOffset).Find("Spell" + (i+1).ToString()).GetComponent<Text>().text = n;
                i++;
            }
        }
        else
            return;
        
    }

    public void Update()
    {
        DisplayUses(spellLevel);
        DisplaySpells(spellLevel);
    }
}
