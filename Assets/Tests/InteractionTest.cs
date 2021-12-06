using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TestTools;

namespace Tests
{
    public class InteractionTest
    {
        private GameObject m_interactionPrefab;
        private GameObject m_playerPrefab;
        private GameObject m_interactablePrefab;

        [SetUp]
        public void Setup()
        {
            Utilities.s_testMode = true;
            m_interactablePrefab = Resources.Load<GameObject>("Prefabs/Interaction/InteractableObject");
            m_interactionPrefab = Resources.Load<GameObject>("Prefabs/Interaction/InteractionBox");
            m_playerPrefab = Resources.Load<GameObject>("Prefabs/Player");
        }

        [TearDown]
        public void Teardown()
        {
            
        }

        [UnityTest]
        public IEnumerator AnyObjectInteractionTest()
        {
            GameObject interactable = Object.Instantiate(m_interactablePrefab);
            GameObject interactionBox = Object.Instantiate(m_interactionPrefab);
            GameObject player = Object.Instantiate(m_playerPrefab);
            player.GetComponent<InteractionController>().InteractionBox = interactionBox;

            player.transform.position = new Vector3(1, 1, 1);
            Vector3 direction = player.transform.position;

            yield return new WaitForSeconds(1.0f);

            Text text = interactionBox.GetComponentInChildren<Canvas>().GetComponentInChildren<Text>();

            bool interacted = direction == player.transform.position;

            yield return new WaitForSeconds(0.1f);

            Assert.AreEqual(interacted, true);

            interactable.tag = "Board";

        }
    }
}
