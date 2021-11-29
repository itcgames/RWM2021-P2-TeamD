﻿using System.Collections;
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
    List<WhiteSpells> currentWhiteSpells;
    List<BlackSpells> currentBlackSpells;
    int spellUses = 0;
    int MaxUses = 2;

    public void AddSpell(SpellType t_type /* character type*/)
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
        spellUses--;
        if (spellUses < 0)
            spellUses = 0;
    }
}
