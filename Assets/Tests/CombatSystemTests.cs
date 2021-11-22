using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

public class CharacterTemplateTests
{
    private GameObject m_characterPrefab;
    private GameObject m_combatPrefab;

    private List<GameObject> m_party;
    private List<GameObject> m_enemies;

    [SetUp]
    public void Setup()
    {
        Utilities.s_testMode = true;

        m_party = new List<GameObject>();
        m_enemies = new List<GameObject>();

        m_characterPrefab = Resources.Load<GameObject>("CharacterTemplate");
        m_combatPrefab = Resources.Load<GameObject>("CombatSystem");
    }

    [TearDown]
    public void Teardown()
    {
        foreach (var item in m_party)
        {
            Object.Destroy(item);
        }

        foreach (var item in m_enemies)
        {
            Object.Destroy(item);
        }
    }

    [UnityTest]
    public IEnumerator SetupCombatValuesTest()
    {
        m_combatPrefab = Object.Instantiate(m_combatPrefab);
        m_combatPrefab.GetComponent<FirstStrikeChance>().SetType(FirstStrikeChance.CheckType.Random);
        m_combatPrefab.GetComponent<FirstStrikeChance>().SetSuccessTest(50.0f);

        GameObject char1 = Object.Instantiate(m_characterPrefab);
        GameObject char2 = Object.Instantiate(m_characterPrefab);
        GameObject char3 = Object.Instantiate(m_characterPrefab);
        GameObject char4 = Object.Instantiate(m_characterPrefab);

        GameObject en1 = Object.Instantiate(m_characterPrefab);
        GameObject en2 = Object.Instantiate(m_characterPrefab);
        GameObject en3 = Object.Instantiate(m_characterPrefab);

        m_party.Add(char1);
        m_party.Add(char2);
        m_party.Add(char3);
        m_party.Add(char4);

        m_enemies.Add(en1);
        m_enemies.Add(en2);
        m_enemies.Add(en3);


        for (int i = 0; i < 4; ++i)
        {
            m_party[i].GetComponent<CharacterAttributes>().Name = "Fighter" + (i + 1).ToString();
        }

        for (int i = 0; i < 3; ++i)
        {
            m_enemies[i].GetComponent<CharacterAttributes>().Name = "Imp" + (i + 1).ToString();
        }

        Dictionary<int, GameObject> battleOrder = new Dictionary<int, GameObject>();

        if (m_combatPrefab.GetComponent<FirstStrikeChance>().FirstStrikeCheckTestVer(60.0f))
        {

            for (int i = 0; i < m_party.Count; ++i)
            {
                battleOrder.Add(i + 1, m_party[i]);
            }

            for (int i = 0; i < m_enemies.Count; ++i)
            {
                battleOrder.Add(i + m_party.Count + 1, m_enemies[i]);
            }
        }
        else
        {
            for (int i = 0; i < m_enemies.Count; ++i)
            {
                battleOrder.Add(i + 1, m_enemies[i]);
            }

            for (int i = 0; i < m_party.Count; ++i)
            {
                battleOrder.Add(i + m_enemies.Count + 1, m_party[i]);
            }
        }

        List<string> recievedOrder = new List<string>();

        for (int i = 0; i < battleOrder.Count; ++i)
        {
            recievedOrder.Add(battleOrder[i + 1].GetComponent<CharacterAttributes>().Name);
        }

        List<string> expectedOrder = new List<string>();
        expectedOrder.Add("Fighter1");
        expectedOrder.Add("Fighter2");
        expectedOrder.Add("Fighter3");
        expectedOrder.Add("Fighter4");
        expectedOrder.Add("Imp1");
        expectedOrder.Add("Imp2");
        expectedOrder.Add("Imp3");

        yield return new WaitForSeconds(0.1f);

        Assert.AreEqual(recievedOrder, expectedOrder);
    }

    [UnityTest]
    public IEnumerator EnemySpawnTest()
    {
        m_combatPrefab = Object.Instantiate(m_combatPrefab);
        m_combatPrefab.GetComponent<FirstStrikeChance>().SetType(FirstStrikeChance.CheckType.Random);
        m_combatPrefab.GetComponent<FirstStrikeChance>().SetSuccessTest(50.0f);

        GameObject char1 = Object.Instantiate(m_characterPrefab);
        GameObject char2 = Object.Instantiate(m_characterPrefab);
        GameObject char3 = Object.Instantiate(m_characterPrefab);
        GameObject char4 = Object.Instantiate(m_characterPrefab);

        m_party.Add(char1);
        m_party.Add(char2);
        m_party.Add(char3);
        m_party.Add(char4);

        Vector3[,] enemyGrid = m_combatPrefab.GetComponent<GenerateGrids>().CreateEnemyGridTest();

        List<GameObject> enemyList = m_combatPrefab.GetComponent<CombatController>().GenerateEnemiesTest();

        enemyList[0].transform.position = enemyGrid[0, 0];

        yield return new WaitForSeconds(0.1f);

        Assert.AreEqual(enemyList[0].transform.position, enemyGrid[0, 0]);

    }
}