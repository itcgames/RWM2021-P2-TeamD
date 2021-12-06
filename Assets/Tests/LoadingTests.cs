using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class LoadingTests
    {
        [UnityTest]
        public IEnumerator CallLoadAfterContinue()
        {
            ScreenSystem t_system = new ScreenSystem();
            t_system.GoToScene(0);

            yield return new WaitForSeconds(0.1f);

            t_system.ContinueGame();

            yield return new WaitForSeconds(0.1f);

            Assert.AreEqual(2, SceneManager.GetActiveScene().buildIndex);
            UnityEngine.Assertions.Assert.IsNotNull(GameObject.FindObjectOfType<PlayerAndGameInfo>().infos);
        }

        [UnityTest]
        public IEnumerator CallLoadAfterLosing()
        {
            ScreenSystem t_system = new ScreenSystem();
            t_system.LoadSaveAfterLose();

            yield return new WaitForSeconds(0.1f);

            //t_system.ContinueGame();

            yield return new WaitForSeconds(0.1f);

            Assert.AreEqual(2, SceneManager.GetActiveScene().buildIndex);
            UnityEngine.Assertions.Assert.IsNotNull(GameObject.FindObjectOfType<PlayerAndGameInfo>().infos);
        }

        [UnityTest]
        public IEnumerator AssignPlayerData()
        {
            GameObject game = new GameObject();
            game.AddComponent<CheckpointSystem>();
            game.AddComponent<ScreenSystem>();
            game.AddComponent<PlayerAndGameInfo>();

           

            yield return new WaitForSeconds(0.1f);

            ScreenSystem t_system = game.GetComponent<ScreenSystem>();
            PlayerAndGameInfo t_info = game.GetComponent<PlayerAndGameInfo>();

            t_info.t_system = game.GetComponent<CheckpointSystem>();

            yield return new WaitForSeconds(0.1f);

            t_system.GoToScene(0);
            string s = t_info.JsonLoadString();

            yield return new WaitForSeconds(0.1f);

            t_system.ContinueGame();

            yield return new WaitForSeconds(0.1f);

            Assert.AreEqual(2, SceneManager.GetActiveScene().buildIndex);
            Assert.AreEqual(s, t_info.JsonLoadString());
        }

        [UnityTest]
        public IEnumerator AssignGameData()
        {
            GameObject game = new GameObject();
            game.AddComponent<CheckpointSystem>();
            game.AddComponent<ScreenSystem>();
            game.AddComponent<PlayerAndGameInfo>();



            yield return new WaitForSeconds(0.1f);

            ScreenSystem t_system = game.GetComponent<ScreenSystem>();
            PlayerAndGameInfo t_info = game.GetComponent<PlayerAndGameInfo>();

            t_info.t_system = game.GetComponent<CheckpointSystem>();

            yield return new WaitForSeconds(0.1f);

            t_system.GoToScene(0);
            string s = t_info.JsonLoadString();

            yield return new WaitForSeconds(0.1f);

            t_system.ContinueGame();

            yield return new WaitForSeconds(0.1f);

            Assert.AreEqual(2, SceneManager.GetActiveScene().buildIndex);
            Assert.AreEqual(400, t_info.infos.m_gil);
        }
    }
}
