using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class FirstStrikeChanceTests
{
    private GameObject m_gamePrefab;
    [SetUp]
    public void Setup()
    {
        m_gamePrefab = Resources.Load<GameObject>("Prefabs/CombatSystem");
    }

    [TearDown]
    public void Teardown()
    {
        Object.Destroy(m_gamePrefab);
    }

    [UnityTest]
    public IEnumerator CalculateFirstStrikeChanceUsingRandomValAndAnATTRTest()
    {
        m_gamePrefab = Object.Instantiate(m_gamePrefab);
        FirstStrikeChance script = m_gamePrefab.GetComponent<FirstStrikeChance>();
        
        script.SetType(FirstStrikeChance.CheckType.RandomInfluencedByAnATTR);
        script.SetAttribute("Speed", 50);
        float randomValSim = 10.0f; // simulate random value

        yield return new WaitForSeconds(0.1f);

        Assert.AreEqual(script.FirstStrikeCheckTestVer(randomValSim), false);
    }

    [UnityTest]
    public IEnumerator CalculateFirstStrikeChanceUsingBooleanExprTest()
    {
        m_gamePrefab = Object.Instantiate(m_gamePrefab);
        FirstStrikeChance script = m_gamePrefab.GetComponent<FirstStrikeChance>();

        script.SetType(FirstStrikeChance.CheckType.BooleanExpressions);
        script.SetOnAdvantage(true);

        yield return new WaitForSeconds(0.1f);

        Assert.AreEqual(script.FirstStrikeCheckTestVer(0.0f), true);
    }
}
