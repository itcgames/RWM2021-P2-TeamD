using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class overworldSystemTest
    {
        private Game m_game;


        [SetUp]
        public void Setup()
        {
            GameObject gameGameObject =
                MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Game"));
            m_game = gameGameObject.GetComponent<Game>();
        }

        [UnityTest]
        public IEnumerator SpawnPlayer()
        {
            bool m_check = m_game.CheckPlayer();
            yield return new WaitForSeconds(1.0f);
            Assert.AreEqual(true, m_check);
        }

/*        [UnityTest] 
        public IEnumerator OverWorld()
        {
            int m_sceneNum = m_game.GetActiveIndex();
            yield return new WaitForSeconds(1.0f);
            Assert.AreEqual(0, m_sceneNum);
        }*/

        [UnityTest]
        public IEnumerator Town()
        {
            m_game.getPlayerModel().moveUp();
            yield return new WaitForSeconds(3.0f);

            int m_sceneNum = m_game.GetActiveIndex();
            Assert.AreEqual(1, m_sceneNum);
        }

    }
}
