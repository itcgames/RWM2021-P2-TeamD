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
        if (t_s == "HP")
            return new Attribute("HP", 80);
        if (t_s == "MHP")
            return new Attribute("MHP", 80);
        else
            return new Attribute("Dmg", 7);
    }

    public static Attribute SetupMage(string t_s)
    {
        if (t_s == "HP")
            return new Attribute("HP", 60);
        if (t_s == "MHP")
            return new Attribute("MHP", 60);
        else
            return new Attribute("Dmg", 17);
    }

    public static Attribute SetupThief(string t_s)
    {
        if (t_s == "HP")
            return new Attribute("HP", 25);
        if (t_s == "MHP")
            return new Attribute("MHP", 25);
        else
            return new Attribute("Dmg", 30);
    }

    public static Attribute SetupBlackBelt(string t_s)
    {
        if (t_s == "HP")
            return new Attribute("HP", 55);
        if (t_s == "MHP")
            return new Attribute("MHP", 55);
        else
            return new Attribute("Dmg", 12);
    }

    public static void LevelUpFighter(CharacterAttributes attrs)
    {
        if (attrs.FindAttribute("MHP") != null && attrs.FindAttribute("HP") != null)
        {
            attrs.FindAttribute("MHP").Value += 8;
            attrs.FindAttribute("HP").Value = attrs.FindAttribute("MHP").Value;
        }

        if(attrs.FindAttribute("Dmg") != null) attrs.FindAttribute("Dmg").Value += 1;
        attrs.LevelUpThreshold += (attrs.LevelUpThreshold / 100 * 140); // 140% increase
        attrs.Xp = 0;
        attrs.Level++;
    }

    public static void LevelUpMage(CharacterAttributes attrs)
    {
        attrs.FindAttribute("MHP").Value += 1;
        attrs.FindAttribute("HP").Value = attrs.FindAttribute("MHP").Value;

        attrs.FindAttribute("Dmg").Value += 4;
        attrs.LevelUpThreshold += (attrs.LevelUpThreshold / 100 * 100); // 100% increase
        attrs.Xp = 0;
        attrs.Level++;
    }

    public static void LevelUpThief(CharacterAttributes attrs)
    {
        attrs.FindAttribute("MHP").Value += 1;
        attrs.FindAttribute("HP").Value = attrs.FindAttribute("MHP").Value;

        attrs.FindAttribute("Dmg").Value += 4;
        attrs.LevelUpThreshold += (attrs.LevelUpThreshold / 100 * 120); // 120% increase
        attrs.Xp = 0;
        attrs.Level++;
    }

    public static void LevelUpBlackBelt(CharacterAttributes attrs)
    {
        attrs.FindAttribute("MHP").Value += 4;
        attrs.FindAttribute("HP").Value = attrs.FindAttribute("MHP").Value;

        attrs.FindAttribute("Dmg").Value += 4;
        attrs.LevelUpThreshold += (attrs.LevelUpThreshold / 100 * 120); // 120% increase
        attrs.Xp = 0;
        attrs.Level++;
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
