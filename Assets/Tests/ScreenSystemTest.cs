using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class ScreenSystemTest
    {
        [UnityTest]
        public IEnumerator SwitchToCharacterSelection()
        {
            ScreenSystem t_system = new ScreenSystem();

            t_system.GoToCharacterSelcetionScene();

            yield return new WaitForSeconds(0.1f);

            Assert.AreEqual(1, SceneManager.GetActiveScene().buildIndex);
        }

        [UnityTest]
        public IEnumerator SwitchToGame()
        {
            ScreenSystem t_system = new ScreenSystem();

            t_system.GoToGameplayScene();

            yield return new WaitForSeconds(0.1f);

            Assert.AreEqual(2, SceneManager.GetActiveScene().buildIndex);
        }

        [UnityTest]
        public IEnumerator SwitchToGameFromContinue()
        {
            ScreenSystem t_system = new ScreenSystem();

            t_system.ContinueGame();

            yield return new WaitForSeconds(0.1f);

            Assert.AreEqual(2, SceneManager.GetActiveScene().buildIndex);
        }

        [UnityTest]
        public IEnumerator SwitchToPauseFromGame()
        {
            ScreenSystem t_system = new ScreenSystem();

            t_system.GoToPauseScreen();

            yield return new WaitForSeconds(0.1f);

            Assert.AreEqual(3, SceneManager.GetActiveScene().buildIndex);
        }

        [UnityTest]
        public IEnumerator SwitchToItemScreen()
        {
            ScreenSystem t_system = new ScreenSystem();

            t_system.GoToPauseScreen();
            GameObject pauseScreen = Resources.Load<GameObject>("Pause"); /*GameObject.Find("Canvas")*/
            GameObject inventories = pauseScreen.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
            inventories.GetComponent<ScreenSystem>().GoToInventoryScreen(0);

            yield return new WaitForSeconds(0.1f);

            Assert.AreEqual(true, inventories.transform.GetChild(0).gameObject.activeInHierarchy);
        }
    }
}
