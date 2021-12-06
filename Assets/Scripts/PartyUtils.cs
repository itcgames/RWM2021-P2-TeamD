enum PartyType
{
    Fighter,
    B_Mage,
    Thief,
    BL_Belt,
}

public class PartyUtil
{

    public static Attribute SetupFighter(string t_s)
    {
        if(t_s == "HP")
            return new Attribute("HP", 35);
        else
            return new Attribute("Dmg", 10);
    }

    public static Attribute SetupMage(string t_s)
    {
        if (t_s == "HP")
            return new Attribute("HP", 25);
        else
            return new Attribute("Dmg", 1);
    }

    public static Attribute SetupThief(string t_s)
    {
        if (t_s == "HP")
            return new Attribute("HP", 30);
        else
            return new Attribute("Dmg", 3);
    }

    public static Attribute SetupBlackBelt(string t_s)
    {
        if (t_s == "HP")
            return new Attribute("HP", 33);
        else
            return new Attribute("Dmg", 3);
    }
}
