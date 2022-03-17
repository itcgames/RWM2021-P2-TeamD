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
        private GameObject m_intance;
        private GameObject m_player;
        private Animator m_animator;
        


        [SetUp]
        public void Setup()
        {
            SceneManager.LoadScene("OverworldScene", LoadSceneMode.Single);
            GameObject gameGameObject =
                MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Game"));
            m_game = gameGameObject.GetComponent<Game>();
            m_intance = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Instance"));
            m_animator = MonoBehaviour.Instantiate(Resources.Load<Animator>("Prefabs/Fade"));
           
        }
        [TearDown]
        public void Teardown()
        {
            if (m_game)
            {
                Object.Destroy(m_game);
            }

            if(m_intance)
            {
                Object.Destroy(m_intance);
            }

           if(m_animator)
            {
                Object.Destroy(m_animator);
            }

        }
        [UnityTest]
        public IEnumerator SpawnPlayer()
        {
            bool m_check = m_game.CheckPlayer();
            yield return new WaitForSeconds(1.0f);
            Assert.AreEqual(true, m_check);
        }

        [UnityTest]
        public IEnumerator EnterTown()
        {
            m_intance = GameObject.Find("TownNorth");
            m_player = GameObject.Find("Player");
            m_animator = GameObject.Find("Fade").GetComponent<Animator>();
            m_intance.transform.position = m_player.transform.position;
            Debug.Log("Has entered Town");
            m_intance = GameObject.Find("Overworld");
            m_intance.transform.position = m_player.transform.position;
            yield return new WaitForSeconds(4.0f);
            int m_sceneNum = m_game.GetActiveIndex();
            Assert.AreEqual(2, m_sceneNum);
        }

        [UnityTest]
        public IEnumerator EnterOverworld()
        {
            SceneManager.LoadScene("Town", LoadSceneMode.Single);
            m_intance = GameObject.Find("Overworld");
            m_player = GameObject.Find("Player");
            m_animator = GameObject.Find("Fade").GetComponent<Animator>();
            m_intance.transform.position = m_player.transform.position;
            Debug.Log("Has entered Overworld");
            m_intance.transform.position = m_player.transform.position;
            yield return new WaitForSeconds(4.0f);
            int m_sceneNum = m_game.GetActiveIndex();
            Assert.AreEqual(5, m_sceneNum);
        }

        [UnityTest]
        public IEnumerator Transition()
        {
            m_intance = GameObject.Find("TownNorth");
            m_player = GameObject.Find("Player");
            m_animator = GameObject.Find("Fade").GetComponent<Animator>();
            m_intance.transform.position = m_player.transform.position;
            m_animator.GetBool("Start");
            Debug.Log("Has entered Town");
            m_intance = GameObject.Find("Overworld");
            m_intance.transform.position = m_player.transform.position;
            yield return new WaitForSeconds(1.0f);
            Assert.True(m_animator.GetBool("Start"));
        }

        [UnityTest]
        public IEnumerator CombatEncounter()
        {
            m_player = GameObject.Find("Player");
            bool check = m_player.GetComponent<Player>().ForceCombatEncounter();
            yield return new WaitForSeconds(1.0f);
            Assert.True(check);

        }

    }
}
