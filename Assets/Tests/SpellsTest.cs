using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class SpellsTest
    {
        [UnityTest]
        public IEnumerator ClassSpecificSpellWhite()
        {
            GameObject gameObject = new GameObject();
            gameObject.AddComponent<Spells>();
            Spells t_spells = gameObject.GetComponent<Spells>();

            yield return new WaitForSeconds(0.1f);

            t_spells.AddSpell(SpellType.WhiteSpells);

            Assert.AreEqual(1, t_spells.currentWhiteSpells.Count);
            Assert.AreEqual(0, t_spells.currentBlackSpells.Count);
        }

        [UnityTest]
        public IEnumerator ClassSpecificSpellBlack()
        {
            GameObject gameObject = new GameObject();
            gameObject.AddComponent<Spells>();
            Spells t_spells = gameObject.GetComponent<Spells>();

            yield return new WaitForSeconds(0.1f);

            t_spells.AddSpell(SpellType.BlackSpells);

            Assert.AreEqual(1, t_spells.currentBlackSpells.Count);
            Assert.AreEqual(0, t_spells.currentWhiteSpells.Count);
        }
    }
}
