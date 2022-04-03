using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class EndpointTests
    {

        [UnityTest]
        public IEnumerator LocationEndpointWorks()
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);

            yield return new WaitForSeconds(0.1f);

            ScreenSystem t_system = GameObject.FindObjectOfType<ScreenSystem>();

            t_system.GoToGameplayScene();

            yield return new WaitForSeconds(0.1f);

            var endpoint = GameObject.Find("EndPoint");
            var player = GameObject.Find("Player");
            endpoint.transform.position = player.transform.position;
            endpoint.transform.position += new Vector3(0.0f, 0.1f, 0.0f);

            yield return new WaitForSeconds(0.1f);

            Assert.AreEqual(2, SceneManager.GetActiveScene().buildIndex);
        }
    }
}
