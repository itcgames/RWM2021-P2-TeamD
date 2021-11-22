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
        public IEnumerator SwitchToItemInventory()
        {
            GameObject gameObject = new GameObject();
            gameObject.AddComponent<ScreenSystem>();
            ScreenSystem t_system = gameObject.GetComponent<ScreenSystem>();

            t_system.GoToPauseScreen();
            t_system.GoToInventoryScreen(0);

            yield return new WaitForSeconds(0.1f);

            Assert.AreEqual(0, t_system.GetCurrentInventory());
        }

        [UnityTest]
        public IEnumerator SwitchToMagicInventory()
        {
            GameObject gameObject = new GameObject();
            gameObject.AddComponent<ScreenSystem>();
            ScreenSystem t_system = gameObject.GetComponent<ScreenSystem>();

            t_system.GoToPauseScreen();
            t_system.GoToInventoryScreen(1);

            yield return new WaitForSeconds(0.1f);

            Assert.AreEqual(1, t_system.GetCurrentInventory());
        }

        [UnityTest]
        public IEnumerator SwitchToWeaponsInventory()
        {
            GameObject gameObject = new GameObject();
            gameObject.AddComponent<ScreenSystem>();
            ScreenSystem t_system = gameObject.GetComponent<ScreenSystem>();

            t_system.GoToPauseScreen();
            t_system.GoToInventoryScreen(2);

            yield return new WaitForSeconds(0.1f);

            Assert.AreEqual(2, t_system.GetCurrentInventory());
        }

        [UnityTest]
        public IEnumerator SwitchToArmourInventory()
        {
            GameObject gameObject = new GameObject();
            gameObject.AddComponent<ScreenSystem>();
            ScreenSystem t_system = gameObject.GetComponent<ScreenSystem>();

            t_system.GoToPauseScreen();
            t_system.GoToInventoryScreen(3);

            yield return new WaitForSeconds(0.1f);

            Assert.AreEqual(3, t_system.GetCurrentInventory());
        }

        [UnityTest]
        public IEnumerator SwitchToStatusInventory()
        {
            GameObject gameObject = new GameObject();
            gameObject.AddComponent<ScreenSystem>();
            ScreenSystem t_system = gameObject.GetComponent<ScreenSystem>();

            t_system.GoToPauseScreen();
            t_system.GoToInventoryScreen(4);

            yield return new WaitForSeconds(0.1f);

            Assert.AreEqual(4, t_system.GetCurrentInventory());
        }
    }
}
