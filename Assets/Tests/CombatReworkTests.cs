using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

public class CombatReworkTests
{
    private GameObject m_enemyBullet;

    [SetUp]
    public void Setup()
    {
        m_enemyBullet = Resources.Load<GameObject>("Prefabs/EnemyBullet");
    }

    [TearDown]
    public void Teardown()
    {
    }

    [UnityTest]
    public IEnumerator EnemyShootTest()
    {
        GameObject enemy = new GameObject();
        enemy.AddComponent<EnemyController>();
        enemy.AddComponent<EnemyID>();

        enemy.GetComponent<EnemyID>().ID = 1;
        enemy.GetComponent<EnemyController>().m_bullet = m_enemyBullet;

        enemy.GetComponent<EnemyController>().Fire(new Vector2(10, 10));

        yield return new WaitForSeconds(0.1f);

        GameObject firedObject = GameObject.Find("EnemyBullet(Clone)");

        Assert.AreEqual(firedObject.tag, "Enemy Bullet");
    }
}