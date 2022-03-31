using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class ItemShopTest
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

            SceneManager.UnloadSceneAsync("ItemShop");
        }
        [UnityTest]
        public IEnumerator buyItem()
        {
            m_item = GameObject.Find("Heal");
            int gil = 400;

            gil -= m_item.GetComponent<ItemID>().getCost();

            yield return new WaitForSeconds(0.5f);
            Assert.AreEqual(340, gil);
        }
        [UnityTest]
        public IEnumerator CheckGil()
        {
            m_item = GameObject.Find("Heal");
            int gil = 200;

            yield return new WaitForSeconds(0.5f);
            Assert.Greater(gil, m_item.GetComponent<ItemID>().getCost());
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
        public IEnumerator BuyingCheckout()
        {
            int gil = 200;
            m_item = GameObject.Find("Heal");

            gil -= m_item.GetComponent<ItemID>().getCost();

            yield return new WaitForSeconds(0.5f);
            Assert.Less(gil, 200);
        }
    }

    public class WeaponShopTest
    {
        private GameObject m_player;
        private GameObject m_item;

        [SetUp]
        public void Setup()
        {
            Utilities.s_testMode = true;
            SceneManager.LoadScene("WeaponShop", LoadSceneMode.Single);
        }
        [TearDown]
        public void TearDown()
        {
            Utilities.s_testMode = false;
            SceneManager.UnloadSceneAsync("WeaponShop");
        }

        [UnityTest]
        public IEnumerator SellWeapon()
        {
            m_item = GameObject.Find("Wooden");
            int gil = 200;
            gil += m_item.GetComponent<ItemID>().getCost() / 2;
            yield return new WaitForSeconds(0.5f);
            Assert.AreEqual(202, gil);
        }
        [UnityTest]
        public IEnumerator CheckItemInventory()
        {
            m_item = GameObject.Find("Wooden");
            m_item.GetComponent<ItemID>().addAmount();
            yield return new WaitForSeconds(0.5f);
            Assert.AreEqual(1, m_item.GetComponent<ItemID>().getAmount());
        }
        [UnityTest]
        public IEnumerator RemoveItem()
        {
            m_item = GameObject.Find("Wooden");
            m_item.GetComponent<ItemID>().addAmount();
            m_item.GetComponent<ItemID>().removeAmount();
            yield return new WaitForSeconds(0.5f);
            Assert.AreEqual(0, m_item.GetComponent<ItemID>().getAmount());
        }
        [UnityTest]
        public IEnumerator SellingCheckout()
        {
            m_item = GameObject.Find("Wooden");
            int gil = 200;
            gil += m_item.GetComponent<ItemID>().getCost();
            yield return new WaitForSeconds(0.5f);
            Assert.Greater(gil, 200);
        }



    }
}



