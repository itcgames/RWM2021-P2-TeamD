using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class CharacterTemplateTests
{
    private GameObject m_characterPrefab;
    [SetUp]
    public void Setup()
    {
        m_characterPrefab = Resources.Load<GameObject>("Prefabs/CharacterTemplate");
    }

    [TearDown]
    public void Teardown()
    {
        Object.Destroy(m_characterPrefab);
    }

    [UnityTest]
    public IEnumerator SetupCombatValuesTest()
    {
        m_characterPrefab = Object.Instantiate(m_characterPrefab);
        m_characterPrefab.GetComponent<CharacterAttributes>().SetAttribute("Hit Points", 200);
        yield return new WaitForSeconds(0.1f);

        Assert.AreEqual(m_characterPrefab.GetComponent<CharacterAttributes>().FindAttribute("Hit Points").Value, 200);
    }

    [UnityTest]
    public IEnumerator SetupSpriteTest()
    {
        m_characterPrefab = Object.Instantiate(m_characterPrefab);
        m_characterPrefab.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprite/ship");
        yield return new WaitForSeconds(0.1f);

        Assert.AreEqual(m_characterPrefab.GetComponent<SpriteRenderer>().sprite.name, "ship");
    }

    [UnityTest]
    public IEnumerator playableStatusTest()
    {
        m_characterPrefab = Object.Instantiate(m_characterPrefab);
        m_characterPrefab.GetComponent<CharacterAttributes>().Playable = true;
        yield return new WaitForSeconds(0.1f);

        Assert.AreEqual(m_characterPrefab.GetComponent<CharacterAttributes>().Playable, true);
    }

    [UnityTest]
    public IEnumerator customAttributeTest()
    {
        m_characterPrefab = Object.Instantiate(m_characterPrefab);
        m_characterPrefab.GetComponent<CharacterAttributes>().AddAttribute(new Attribute("Luck", 20));
        yield return new WaitForSeconds(0.1f);

        Assert.AreEqual(m_characterPrefab.GetComponent<CharacterAttributes>().FindAttribute("Luck").Name, "Luck");
    }
}
