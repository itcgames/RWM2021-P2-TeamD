enum EnemyType
{
    Imp,
    Wolf,
    Spider
}

public class EnemyUtil
{

    public static void SetupImp(CharacterAttributes attrs)
    {
        attrs.ClearAttributes();

        attrs.Name = "Imp";
        attrs.Playable = false;
        attrs.Gil = 6;
        attrs.Xp = 8;

        Attribute hp = new Attribute("HP", 8);
        Attribute dmg = new Attribute("Dmg", 4);
        attrs.AddAttribute(hp);
        attrs.AddAttribute(dmg);
    }

    public static void SetupWolf(CharacterAttributes attrs)
    {
        attrs.ClearAttributes();

        attrs.Name = "Wolf";
        attrs.Playable = false;
        attrs.Gil = 6;
        attrs.Xp = 24;

        Attribute hp = new Attribute("HP", 20);
        Attribute dmg = new Attribute("Dmg", 8);
        attrs.AddAttribute(hp);
        attrs.AddAttribute(dmg);
    }

    public static void SetupSpider(CharacterAttributes attrs)
    {
        attrs.ClearAttributes();

        attrs.Name = "Spider";
        attrs.Playable = false;
        attrs.Gil = 8;
        attrs.Xp = 30;

        Attribute hp = new Attribute("HP", 28);
        Attribute dmg = new Attribute("Dmg", 10);
        attrs.AddAttribute(hp);
        attrs.AddAttribute(dmg);
    }
}
