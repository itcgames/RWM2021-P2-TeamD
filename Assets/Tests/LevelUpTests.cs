using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

public class LevelUpTests
{
    private GameObject m_enemyBullet;
    private GameObject m_characterPrefab;

    [SetUp]
    public void Setup()
    {
        m_characterPrefab = Resources.Load<GameObject>("CharacterTemplate");
    }

    [TearDown]
    public void Teardown()
    {
    }

    [UnityTest]
    public IEnumerator LevelUpTest()
    {
        GameObject player = Object.Instantiate(m_characterPrefab);

        Attribute mhp = new Attribute("MHP", 150);

        player.GetComponent<CharacterAttributes>().AddAttribute(mhp);
        player.GetComponent<CharacterAttributes>().Level = 1;
        player.GetComponent<CharacterAttributes>().LevelUpThreshold = 10;
        player.GetComponent<CharacterAttributes>().Xp = 10;

        if(player.GetComponent<CharacterAttributes>().Xp >= player.GetComponent<CharacterAttributes>().LevelUpThreshold)
        {
            PartyUtil.LevelUpFighter(player.GetComponent<CharacterAttributes>());
        }

        yield return new WaitForSeconds(0.1f);

        Assert.AreEqual(2, player.GetComponent<CharacterAttributes>().Level);
    }
}