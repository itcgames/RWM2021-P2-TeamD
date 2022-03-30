using System.Collections.Generic;
enum EnemyType
{
    Bandit,
    DesertWarrior,
    Cactus,
    DesertShinobi,
    DarkShinobi,
    ShadeShinobi,
    Snail
}

public class EnemyUtil
{
    public static int s_currentEnemyID = 0;

    public static bool[] s_enemyAliveStatus = new bool[20];

    public static void ResetEnemyStatus()
    {
        for (int i = 0; i < s_enemyAliveStatus.Length; ++i)
        {
            s_enemyAliveStatus[i] = true;
        }
    }

    

    public static void SetupBandit(CharacterAttributes attrs)
    {
        attrs.ClearAttributes();

        attrs.Name = "Bandit";
        attrs.Playable = false;
        attrs.Gold = 6;
        attrs.Xp = 8;

        Attribute mhp = new Attribute("MHP", 8);
        Attribute hp = new Attribute("HP", 8);
        Attribute dmg = new Attribute("Dmg", 4);
        attrs.AddAttribute(mhp);
        attrs.AddAttribute(hp);
        attrs.AddAttribute(dmg);
    }

    public static void SetupWarrior(CharacterAttributes attrs)
    {
        attrs.ClearAttributes();

        attrs.Name = "Desert Warrior";
        attrs.Playable = false;
        attrs.Gold = 10;
        attrs.Xp = 10;

        Attribute mhp = new Attribute("MHP", 10);
        Attribute hp = new Attribute("HP", 10);
        Attribute dmg = new Attribute("Dmg", 6);
        attrs.AddAttribute(mhp);
        attrs.AddAttribute(hp);
        attrs.AddAttribute(dmg);
    }

    public static void SetupCactus(CharacterAttributes attrs)
    {
        attrs.ClearAttributes();

        attrs.Name = "Cactus";
        attrs.Playable = false;
        attrs.Gold = 3;
        attrs.Xp = 4;

        Attribute mhp = new Attribute("MHP", 5);
        Attribute hp = new Attribute("HP", 5);
        Attribute dmg = new Attribute("Dmg", 3);
        attrs.AddAttribute(mhp);
        attrs.AddAttribute(hp);
        attrs.AddAttribute(dmg);
    }

    public static void SetupShinobiDesert(CharacterAttributes attrs)
    {
        attrs.ClearAttributes();

        attrs.Name = "Desert Shinobi";
        attrs.Playable = false;
        attrs.Gold = 20;
        attrs.Xp = 40;

        Attribute mhp = new Attribute("MHP", 15);
        Attribute hp = new Attribute("HP", 15);
        Attribute dmg = new Attribute("Dmg", 6);
        attrs.AddAttribute(mhp);
        attrs.AddAttribute(hp);
        attrs.AddAttribute(dmg);
    }

    public static void SetupShinobiDark(CharacterAttributes attrs)
    {
        attrs.ClearAttributes();

        attrs.Name = "Dark Shinobi";
        attrs.Playable = false;
        attrs.Gold = 30;
        attrs.Xp = 45;

        Attribute mhp = new Attribute("MHP", 25);
        Attribute hp = new Attribute("HP", 25);
        Attribute dmg = new Attribute("Dmg", 8);
        attrs.AddAttribute(mhp);
        attrs.AddAttribute(hp);
        attrs.AddAttribute(dmg);
    }

    public static void SetupShinobiShade(CharacterAttributes attrs)
    {
        attrs.ClearAttributes();

        attrs.Name = "Shade Shinobi";
        attrs.Playable = false;
        attrs.Gold = 50;
        attrs.Xp = 65;

        Attribute mhp = new Attribute("MHP", 10);
        Attribute hp = new Attribute("HP", 10);
        Attribute dmg = new Attribute("Dmg", 15);
        attrs.AddAttribute(mhp);
        attrs.AddAttribute(hp);
        attrs.AddAttribute(dmg);
    }

    public static void SetupSnail(CharacterAttributes attrs)
    {
        attrs.ClearAttributes();

        attrs.Name = "Snail";
        attrs.Playable = false;
        attrs.Gold = 2;
        attrs.Xp = 1;

        Attribute mhp = new Attribute("MHP", 2);
        Attribute hp = new Attribute("HP", 2);
        Attribute dmg = new Attribute("Dmg", 1);
        attrs.AddAttribute(mhp);
        attrs.AddAttribute(hp);
        attrs.AddAttribute(dmg);
    }
}
