using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class usetemTest
    {
        
        
        GameObject testItem;
        [SetUp]
        public void SetUp()
        {
            SceneManager.LoadScene("itemScene");
            
        }
       [TearDown]
       public void TearDown()
        {
            SceneManager.UnloadSceneAsync("itemScene");
        }
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator SetupAmount()
        {
            SceneManager.LoadScene(6);
            yield return new WaitForSeconds(0.1f);

            setupItem itemTest = GameObject.FindObjectOfType<setupItem>();
            int expected = itemTest.getAmount();
            Assert.AreEqual(expected, 55);
            yield return null;

        }

        [UnityTest]
        public IEnumerator Healamount()
        {
            SceneManager.LoadScene(6);
            yield return new WaitForSeconds(0.1f);

            GameObject camera = GameObject.Find("inven");
            camera.GetComponent<ActivateAndDeactivate>().ChangeInventory(true);
            camera.GetComponent<ActivateAndDeactivate>().ChangeUse(true);
            GameObject playerTest = GameObject.Find("playerData");
            GameObject itemTest = GameObject.Find("item");
            playerTest.GetComponent<UseItem>().heal();
            int expected = playerTest.GetComponent<UseItem>().PlayerHealth + playerTest.GetComponent<UseItem>().healAmount;


            yield return null;
            Assert.Less(expected, 60);


        }
    }
}
