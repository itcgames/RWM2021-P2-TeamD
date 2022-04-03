using System.Collections.Generic;
enum EnemyType
{
    Snail,
    Cactus,
    Bandit,
    DesertWarrior,
    DesertShinobi,
    DarkShinobi,
    ShadeShinobi,
    BossBoss,
    BossSpy,
    BossMan,
    BossWalk,
    BossBossBoss,
    BossWife
}

public class EnemyUtil
{
    public static int s_currentEnemyID = 0;

    public static bool[] s_enemyAliveStatus = new bool[18];

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

        attrs.Name = "BANDIT";
        attrs.Playable = false;
        attrs.Gold = 6;
        attrs.Xp = 8;

        Attribute mhp = new Attribute("MHP", 15);
        Attribute hp = new Attribute("HP", 15);
        Attribute dmg = new Attribute("Dmg", 4);
        Attribute def = new Attribute("Def", 2);
        attrs.AddAttribute(mhp);
        attrs.AddAttribute(hp);
        attrs.AddAttribute(dmg);
        attrs.AddAttribute(def);
    }

    public static void SetupWarrior(CharacterAttributes attrs)
    {
        attrs.ClearAttributes();

        attrs.Name = "WARRIOR";
        attrs.Playable = false;
        attrs.Gold = 52;
        attrs.Xp = 45;

        Attribute mhp = new Attribute("MHP", 75);
        Attribute hp = new Attribute("HP", 75);
        Attribute dmg = new Attribute("Dmg", 2);
        Attribute def = new Attribute("Def", 50);
        attrs.AddAttribute(mhp);
        attrs.AddAttribute(hp);
        attrs.AddAttribute(dmg);
        attrs.AddAttribute(def);
    }

    public static void SetupCactus(CharacterAttributes attrs)
    {
        attrs.ClearAttributes();

        attrs.Name = "CACTUS";
        attrs.Playable = false;
        attrs.Gold = 3;
        attrs.Xp = 4;

        Attribute mhp = new Attribute("MHP", 5);
        Attribute hp = new Attribute("HP", 5);
        Attribute dmg = new Attribute("Dmg", 3);
        Attribute def = new Attribute("Def", 1);
        attrs.AddAttribute(mhp);
        attrs.AddAttribute(hp);
        attrs.AddAttribute(dmg);
        attrs.AddAttribute(def);
    }

    public static void SetupShinobiDesert(CharacterAttributes attrs)
    {
        attrs.ClearAttributes();

        attrs.Name = "DESERT NINJA";
        attrs.Playable = false;
        attrs.Gold = 15;
        attrs.Xp = 35;

        Attribute mhp = new Attribute("MHP", 15);
        Attribute hp = new Attribute("HP", 15);
        Attribute dmg = new Attribute("Dmg", 6);
        Attribute def = new Attribute("Def", 2);
        attrs.AddAttribute(mhp);
        attrs.AddAttribute(hp);
        attrs.AddAttribute(dmg);
        attrs.AddAttribute(def);
    }

    public static void SetupShinobiDark(CharacterAttributes attrs)
    {
        attrs.ClearAttributes();

        attrs.Name = "DARK NINJA";
        attrs.Playable = false;
        attrs.Gold = 67;
        attrs.Xp = 64;

        Attribute mhp = new Attribute("MHP", 25);
        Attribute hp = new Attribute("HP", 25);
        Attribute dmg = new Attribute("Dmg", 9);
        Attribute def = new Attribute("Def", 10);
        attrs.AddAttribute(mhp);
        attrs.AddAttribute(hp);
        attrs.AddAttribute(dmg);
        attrs.AddAttribute(def);
    }

    // rare enemy
    public static void SetupShinobiShade(CharacterAttributes attrs)
    {
        attrs.ClearAttributes();

        attrs.Name = "SHADE NINJA";
        attrs.Playable = false;
        attrs.Gold = 142;
        attrs.Xp = 312;

        Attribute mhp = new Attribute("MHP", 50);
        Attribute hp = new Attribute("HP", 50);
        Attribute dmg = new Attribute("Dmg", 35);
        Attribute def = new Attribute("Def", 10);
        attrs.AddAttribute(mhp);
        attrs.AddAttribute(hp);
        attrs.AddAttribute(dmg);
        attrs.AddAttribute(def);
    }

    public static void SetupSnail(CharacterAttributes attrs)
    {
        attrs.ClearAttributes();

        attrs.Name = "SNAIL";
        attrs.Playable = false;
        attrs.Gold = 2;
        attrs.Xp = 1;

        Attribute mhp = new Attribute("MHP", 2);
        Attribute hp = new Attribute("HP", 2);
        Attribute dmg = new Attribute("Dmg", 1);
        Attribute def = new Attribute("Def", 1);
        attrs.AddAttribute(mhp);
        attrs.AddAttribute(hp);
        attrs.AddAttribute(dmg);
        attrs.AddAttribute(def);
    }

    public static void SetupBossBoss(CharacterAttributes attrs)
    {
        attrs.ClearAttributes();

        attrs.Name = "STOIC MASS";
        attrs.Playable = false;
        attrs.Gold = 132;
        attrs.Xp = 87;

        Attribute mhp = new Attribute("MHP", 120);
        Attribute hp = new Attribute("HP", 120);
        Attribute dmg = new Attribute("Dmg", 3);
        Attribute def = new Attribute("Def", 50);
        attrs.AddAttribute(mhp);
        attrs.AddAttribute(hp);
        attrs.AddAttribute(dmg);
        attrs.AddAttribute(def);
    }

    public static void SetupBossMan(CharacterAttributes attrs)
    {
        attrs.ClearAttributes();

        attrs.Name = "THE SKINHEAD";
        attrs.Playable = false;
        attrs.Gold = 67;
        attrs.Xp = 89;

        Attribute mhp = new Attribute("MHP", 50);
        Attribute hp = new Attribute("HP", 50);
        Attribute dmg = new Attribute("Dmg", 6);
        Attribute def = new Attribute("Def", 2);
        attrs.AddAttribute(mhp);
        attrs.AddAttribute(hp);
        attrs.AddAttribute(dmg);
        attrs.AddAttribute(def);
    }

    public static void SetupBossWife(CharacterAttributes attrs)
    {
        attrs.ClearAttributes();

        attrs.Name = "GATEKEEPER";
        attrs.Playable = false;
        attrs.Gold = 104;
        attrs.Xp = 102;

        Attribute mhp = new Attribute("MHP", 100);
        Attribute hp = new Attribute("HP", 100);
        Attribute dmg = new Attribute("Dmg", 5);
        Attribute def = new Attribute("Def", 20);
        attrs.AddAttribute(mhp);
        attrs.AddAttribute(hp);
        attrs.AddAttribute(dmg);
        attrs.AddAttribute(def);
    }

    public static void SetupBossSpy(CharacterAttributes attrs)
    {
        attrs.ClearAttributes();

        attrs.Name = "SLEEPING THUG";
        attrs.Playable = false;
        attrs.Gold = 98;
        attrs.Xp = 56;

        Attribute mhp = new Attribute("MHP", 45);
        Attribute hp = new Attribute("HP", 45);
        Attribute dmg = new Attribute("Dmg", 30);
        Attribute def = new Attribute("Def", 20);
        attrs.AddAttribute(mhp);
        attrs.AddAttribute(hp);
        attrs.AddAttribute(dmg);
        attrs.AddAttribute(def);
    }

    public static void SetupBossBossBoss(CharacterAttributes attrs)
    {
        attrs.ClearAttributes();

        attrs.Name = "AWOKEN THUG";
        attrs.Playable = false;
        attrs.Gold = 1300;
        attrs.Xp = 520;

        Attribute mhp = new Attribute("MHP", 250);
        Attribute hp = new Attribute("HP", 250);
        Attribute dmg = new Attribute("Dmg", 10);
        Attribute def = new Attribute("Def", 50);
        attrs.AddAttribute(mhp);
        attrs.AddAttribute(hp);
        attrs.AddAttribute(dmg);
        attrs.AddAttribute(def);
    }

    public static void SetupBossWalk(CharacterAttributes attrs)
    {
        attrs.ClearAttributes();

        attrs.Name = "STOIC WALKER";
        attrs.Playable = false;
        attrs.Gold = 124;
        attrs.Xp = 96;

        Attribute mhp = new Attribute("MHP", 75);
        Attribute hp = new Attribute("HP", 75);
        Attribute dmg = new Attribute("Dmg", 25);
        Attribute def = new Attribute("Def", 20);
        attrs.AddAttribute(mhp);
        attrs.AddAttribute(hp);
        attrs.AddAttribute(dmg);
        attrs.AddAttribute(def);
    }
}
