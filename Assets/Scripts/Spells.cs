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
    Fire,
    Thunder,
    Focus,
    Sleep,
    Dark,
    Blizzard,
    Slow,
    Temper,
    Fira,
    Hold,
    Thundara,
    Focara,
    Confuse,
    Haste,
    Blizzara,
    Sleepra,
    Scourge,
    Firaga,
    Slowra,
    Teleport,
    Thundaga,
    Quake,
    Death,
    Stun,
    Blind,
    Break,
    Blizzaga,
    Saber,
    Flare,
    Stop,
    Kill,
    Warp
}

public enum WhiteSpells
{
    //White
    Cure,
    Protect,
    Dia,
    Blink,
    NulShock,
    Invis,
    Blinda,
    Silence,
    NulBlaze,
    Cura,
    Heal,
    Diara,
    NulFrost,
    Vox,
    Fear,
    Poisona,
    Curaga,
    Healara,
    Diaga,
    Life,
    Exit,
    Protera,
    Invisira,
    Stona,
    NulDeath,
    Curaja,
    Healaga,
    Diaja,
    Holy,
    Full_Life,
    NulAll,
    Dispel
}

public class Spells : MonoBehaviour
{
    
    void AddSpell(SpellType t_type /* character type*/)
    {
        if(t_type.ToString() == "WhiteSpells")
        {

        }
        else
        {

        }
    }
}
