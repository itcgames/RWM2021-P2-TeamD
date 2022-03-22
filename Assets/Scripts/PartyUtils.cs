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
        if (t_s == "MHP")
            return new Attribute("MHP", 35);
        else
            return new Attribute("Dmg", 10);
    }

    public static Attribute SetupMage(string t_s)
    {
        if (t_s == "HP")
            return new Attribute("HP", 25);
        if (t_s == "MHP")
            return new Attribute("MHP", 25);
        else
            return new Attribute("Dmg", 1);
    }

    public static Attribute SetupThief(string t_s)
    {
        if (t_s == "HP")
            return new Attribute("HP", 30);
        if (t_s == "MHP")
            return new Attribute("MHP", 30);
        else
            return new Attribute("Dmg", 3);
    }

    public static Attribute SetupBlackBelt(string t_s)
    {
        if (t_s == "HP")
            return new Attribute("HP", 33);
        if (t_s == "MHP")
            return new Attribute("MHP", 33);
        else
            return new Attribute("Dmg", 3);
    }

    public static float MaxHealth(int t_s)
    {
        switch (t_s)
        {
            case ((int)PartyType.BL_Belt):
                return SetupBlackBelt("MHP").Value;
            case ((int)PartyType.Fighter):
                return SetupFighter("MHP").Value;
            case ((int)PartyType.Thief):
                return SetupThief("MHP").Value;
            case ((int)PartyType.B_Mage):
                return SetupMage("MHP").Value;
            default:
                return 0.0f;
        }
    }
}
