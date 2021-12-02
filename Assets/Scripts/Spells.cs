using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SpellType
{
    WhiteSpells,
    BlackSpells
}

public enum BlackSpells
{
    //Black
    Fire
}

public enum WhiteSpells
{
    //White
    Cure
}

public class Spells : MonoBehaviour
{
    public List<WhiteSpells> currentWhiteSpells;
    public List<BlackSpells> currentBlackSpells;
    int spellUses = 2;
    int MaxUses = 2;

    private void Start()
    {
        currentWhiteSpells = new List<WhiteSpells>();
        currentBlackSpells = new List<BlackSpells>();
    }

    public void AddSpell(SpellType t_type /*character type*/)
    {
        if(t_type.ToString() == "WhiteSpells")
        {
            currentWhiteSpells.Add(WhiteSpells.Cure);
        }
        else
        {
            currentBlackSpells.Add(BlackSpells.Fire);
        }
    }

    public int UsesLeft()
    {
        return spellUses; 
    }
    public int MaxUsesAmount()
    {
        return MaxUses;
    }

    public List<WhiteSpells> GetWhiteSpells()
    {
        return currentWhiteSpells;
    }

    public List<BlackSpells> GetBlackSpells()
    {
        return currentBlackSpells;
    }


    public void RechargeUses()
    {
        spellUses = MaxUses;
    }

    public void SetMaxUses(int t_increase)
    {
        MaxUses += t_increase;
    }

    public void useSpell()
    {
        if (spellUses != 0)
        {
            if (currentBlackSpells != null)
            {
                //damage enemy
            }
            else if (currentWhiteSpells != null)
            {
                //heal character
            }
            spellUses--;
        }
        //if (spellUses < 0)
        //    spellUses = 0;
    }
}
