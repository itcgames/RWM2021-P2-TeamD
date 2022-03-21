using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class NewEnemyBahaviourTest
    {
        [UnityTest]
        public IEnumerator RadiusDistanceDetectsPlayer()
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);

            yield return new WaitForSeconds(0.1f);

            ScreenSystem t_system = GameObject.FindObjectOfType<ScreenSystem>();

            t_system.GoToGameplayScene();

            yield return new WaitForSeconds(0.1f);

            var enemy = GameObject.Find("Enemy (1)");
            var player = GameObject.Find("Player");

            yield return new WaitForSeconds(0.1f);

            Assert.AreEqual(true, enemy.GetComponent<EnemyBehaviours>().m_wander);
            Assert.AreEqual(false, enemy.GetComponent<EnemyBehaviours>().m_player_detected);


            enemy.transform.position = player.transform.position - new Vector3(0.5f, 0f, 0f);

            yield return new WaitForSeconds(0.1f);

            Assert.AreEqual(false, enemy.GetComponent<EnemyBehaviours>().m_wander);
            Assert.AreEqual(true, enemy.GetComponent<EnemyBehaviours>().m_player_detected);
        }

        [UnityTest]
        public IEnumerator VisionConeDetectsPlayer()
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);

            yield return new WaitForSeconds(0.1f);

            ScreenSystem t_system = GameObject.FindObjectOfType<ScreenSystem>();

            t_system.GoToGameplayScene();

            yield return new WaitForSeconds(0.1f);

            var enemy = GameObject.Find("Enemy (1)");
            var player = GameObject.Find("Player");

            Assert.AreEqual(true, enemy.GetComponent<EnemyBehaviours>().m_wander);
            Assert.AreEqual(false, enemy.GetComponent<EnemyBehaviours>().m_player_detected);

            enemy.transform.position = player.transform.position - new Vector3(0f, .9f, 0f);

            yield return new WaitForSeconds(0.1f);

            Assert.AreEqual(false, enemy.GetComponent<EnemyBehaviours>().m_wander);
            Assert.AreEqual(true, enemy.GetComponent<EnemyBehaviours>().m_player_detected);
        }
    }
}
