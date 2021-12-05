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
    }
}
