using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class ShopTest
    {
        private GameObject m_player;
        private GameObject m_item;

        [SetUp]
        public void Setup()
        {
            SceneManager.LoadScene("ItemShop", LoadSceneMode.Single);
        }
        [TearDown]
        public void TearDown()
        {
            //SceneManager.UnloadSceneAsync("ItemShop");
        }



        [UnityTest]
        public IEnumerator buyItem()
        {
            m_player = GameObject.Find("Player");
            m_item = GameObject.Find("Heal");
            m_player.GetComponent<Player>().setGil(200);
            m_player.GetComponent<Player>().setGil(-m_item.GetComponent<ItemID>().getCost());
            yield return new WaitForSeconds(0.5f);
            Assert.AreEqual(140, m_player.GetComponent<Player>().getGil());
        }
        [UnityTest]
        public IEnumerator CheckGil()
        {
            m_player = GameObject.Find("Player");
            m_item = GameObject.Find("Heal");
            m_player.GetComponent<Player>().setGil(200);
            yield return new WaitForSeconds(0.5f);
            Assert.Greater(m_player.GetComponent<Player>().getGil(), m_item.GetComponent<ItemID>().getCost());
        }
        [UnityTest]
        public IEnumerator CheckInventory()
        {
            m_item = GameObject.Find("Heal");
            m_item.GetComponent<ItemID>().addAmount();
            yield return new WaitForSeconds(0.5f);
            Assert.AreEqual(1, m_item.GetComponent<ItemID>().getAmount());
        }
        [UnityTest]
        public IEnumerator GilCheckout()
        {
            m_player = GameObject.Find("Player");
            m_item = GameObject.Find("Heal");
            m_player.GetComponent<Player>().setGil(200);
            m_player.GetComponent<Player>().setGil(-m_item.GetComponent<ItemID>().getCost());
            yield return new WaitForSeconds(0.5f);
            Assert.Less(m_player.GetComponent<Player>().getGil(), 200);
        }







    }
}
