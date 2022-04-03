using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class CollisionTest
    {
        private GameObject m_player;
        private GameObject m_instance;


        [SetUp]
        public void Setup()
        {
            SceneManager.LoadScene("OverworldScene", LoadSceneMode.Single);
        }
        // A Test behaves as an ordinary method

        [UnityTest]
        public IEnumerator RiverCollision()
        {
            m_player = GameObject.Find("Player");
            m_player.transform.position = new Vector2(-4.9f, 1.4f);
            m_player.transform.position += new Vector3(-0.5f, 0,0);
            yield return new WaitForSeconds(0.5f);
            Assert.AreEqual(true, m_player.GetComponent<Player>().getCollisionCheck());
        }

        [UnityTest]
        public IEnumerator BoulderCollision()
        {
            m_player = GameObject.Find("Player");
            m_player.transform.position = new Vector2(-10.53f, 2.5f);
            m_player.transform.position += new Vector3(0, 1f, 0);
            yield return new WaitForSeconds(0.5f);
            Assert.AreEqual(true,m_player.GetComponent<Player>().getCollisionCheck());
        }

    }
}
