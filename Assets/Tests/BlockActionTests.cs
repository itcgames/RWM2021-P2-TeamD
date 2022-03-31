using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

public class BlockActionTests
{
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
    public IEnumerator BlockDamageReductionTest()
    {
        GameObject player = Object.Instantiate(m_characterPrefab);

        Attribute mhp = new Attribute("MHP", 150);
        Attribute def = new Attribute("Def", 40);

        player.GetComponent<CharacterAttributes>().AddAttribute(mhp);
        player.GetComponent<CharacterAttributes>().AddAttribute(def);

        float dmg = 100;
        float targetDef = 40;

        int totalReduction = ActionController.CalculateDmgReduction(dmg, targetDef, true);

        yield return new WaitForSeconds(0.1f);

        Assert.That(totalReduction, Is.GreaterThanOrEqualTo(80));
    }
}