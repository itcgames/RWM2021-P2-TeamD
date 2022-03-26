using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

public class BattleRewardsTests
{
    private GameObject m_enemyBullet;

    [SetUp]
    public void Setup()
    {
        
    }

    [TearDown]
    public void Teardown()
    {
    }

    [UnityTest]
    public IEnumerator CalculateGoldXpTest()
    {
        List<GameObject> enemies = new List<GameObject>();

        for (int i = 0; i < 10; ++i)
        {
            GameObject enemy = new GameObject();
            enemy.AddComponent<CharacterAttributes>();
            enemy.GetComponent<CharacterAttributes>().Gold = 5;
            enemy.GetComponent<CharacterAttributes>().Xp = 2;

            enemies.Add(enemy);
        }

        int goldReward = 0;
        int xpReward = 0;

        CombatController.CalculateGoldXpRewards(ref goldReward, ref xpReward, enemies);

        yield return new WaitForSeconds(0.1f);

        Assert.AreEqual(50, goldReward);
        Assert.AreEqual(20, xpReward);
    }
}