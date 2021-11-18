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
    }
}
