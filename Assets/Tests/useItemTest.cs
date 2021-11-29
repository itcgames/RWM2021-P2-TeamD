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
            SceneManager.LoadScene("item");
            
        }
       [TearDown]
       public void TearDown()
        {
            SceneManager.UnloadSceneAsync("item");
        }
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator SetupAmount()
        {
            GameObject itemTest = GameObject.Find("item");
            int expected = itemTest.GetComponent<setupItem>().getAmount();
            Assert.AreEqual(expected, 55);
            yield return null;

        }
        [UnityTest]
        public IEnumerator UseAmount()
        {

            GameObject camera = GameObject.Find("inven");
            camera.GetComponent<ActivateAndDeactivate>().ChangeInventory(true);
            camera.GetComponent<ActivateAndDeactivate>().ChangeUse(true);
            GameObject playerTest = GameObject.Find("playerData");
            GameObject itemTest = GameObject.Find("item");
            playerTest.GetComponent<UseItem>().use();
            int expected = itemTest.GetComponent<setupItem>().getAmount();


            yield return null;
            Assert.Less(expected, 55);
          

        }
        [UnityTest]
        public IEnumerator Healamount()
        {

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
