using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;
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

        [UnityTest]
        public IEnumerator PickTheItemInventory()
        {
            GameObject gameObject = new GameObject();
            gameObject.AddComponent<ScreenSystem>();
            gameObject.AddComponent<RectTransform>();
            ScreenSystem t_system = new ScreenSystem();
            t_system.GoToPauseScreen();

            yield return new WaitForSeconds(0.1f);

            gameObject.AddComponent<Cursor>();
            Cursor t_cursor = gameObject.GetComponent<Cursor>();

            yield return new WaitForSeconds(0.1f);
            ScreenSystem t_cursScreenSys = t_cursor.t_screenSystem;
            t_cursor.UseFunctionality(t_cursor.currentInvPos);

            Assert.AreEqual(0, t_cursScreenSys.GetCurrentInventory());
        }

        [UnityTest]
        public IEnumerator PickTheWeaponsInventory()
        {
            GameObject gameObject = new GameObject();
            gameObject.AddComponent<ScreenSystem>();
            gameObject.AddComponent<RectTransform>();
            ScreenSystem t_system = new ScreenSystem();
            t_system.GoToPauseScreen();

            yield return new WaitForSeconds(0.1f);

            gameObject.AddComponent<Cursor>();
            Cursor t_cursor = gameObject.GetComponent<Cursor>();

            yield return new WaitForSeconds(0.1f);
            ScreenSystem t_cursScreenSys = t_cursor.t_screenSystem;
            t_cursor.MoveDown();
            t_cursor.MoveDown();
            t_cursor.UseFunctionality(t_cursor.currentInvPos);

            Assert.AreEqual(2, t_cursScreenSys.GetCurrentInventory());
        }

        [UnityTest]
        public IEnumerator PickTheArmourInventory()
        {
            GameObject gameObject = new GameObject();
            gameObject.AddComponent<ScreenSystem>();
            gameObject.AddComponent<RectTransform>();
            ScreenSystem t_system = new ScreenSystem();
            t_system.GoToPauseScreen();

            yield return new WaitForSeconds(0.1f);

            gameObject.AddComponent<Cursor>();
            Cursor t_cursor = gameObject.GetComponent<Cursor>();

            yield return new WaitForSeconds(0.1f);
            ScreenSystem t_cursScreenSys = t_cursor.t_screenSystem;
            t_cursor.MoveDown();
            t_cursor.MoveDown();
            t_cursor.MoveDown();
            t_cursor.UseFunctionality(t_cursor.currentInvPos);

            Assert.AreEqual(3, t_cursScreenSys.GetCurrentInventory());
        }

        [UnityTest]
        public IEnumerator PickTheMagicInventory()
        {
            GameObject gameObject = new GameObject();
            gameObject.AddComponent<ScreenSystem>();
            gameObject.AddComponent<RectTransform>();
            ScreenSystem t_system = new ScreenSystem();
            t_system.GoToPauseScreen();

            yield return new WaitForSeconds(0.1f);

            gameObject.AddComponent<Cursor>();
            Cursor t_cursor = gameObject.GetComponent<Cursor>();

            yield return new WaitForSeconds(0.1f);
            ScreenSystem t_cursScreenSys = t_cursor.t_screenSystem;
            t_cursor.MoveDown();
            t_cursor.UseFunctionality(t_cursor.currentInvPos);
            t_cursor.MoveRight();
            t_cursor.GoToCharInventory(t_cursor.currentCharPos);


            Assert.AreEqual(1, t_cursScreenSys.GetCurrentInventory());
        }

        [UnityTest]
        public IEnumerator PickTheStatusInventory()
        {
            GameObject gameObject = new GameObject();
            gameObject.AddComponent<ScreenSystem>();
            gameObject.AddComponent<RectTransform>();
            ScreenSystem t_system = new ScreenSystem();
            t_system.GoToPauseScreen();

            yield return new WaitForSeconds(0.1f);

            gameObject.AddComponent<Cursor>();
            Cursor t_cursor = gameObject.GetComponent<Cursor>();

            yield return new WaitForSeconds(0.1f);
            ScreenSystem t_cursScreenSys = t_cursor.t_screenSystem;
            t_cursor.MoveDown();
            t_cursor.MoveDown();
            t_cursor.MoveDown();
            t_cursor.MoveDown();
            t_cursor.MoveDown();
            t_cursor.UseFunctionality(t_cursor.currentInvPos);
            t_cursor.MoveRight();
            t_cursor.MoveDown1();
            t_cursor.GoToCharInventory(t_cursor.currentCharPos);


            Assert.AreEqual(4, t_cursScreenSys.GetCurrentInventory());
        }

        [UnityTest]
        public IEnumerator DisplayCurrentUses()
        {
            GameObject gameObject = new GameObject();
            gameObject.AddComponent<ScreenSystem>();
            gameObject.AddComponent<RectTransform>();
            ScreenSystem t_system = new ScreenSystem();
            t_system.GoToPauseScreen();

            yield return new WaitForSeconds(0.1f);

            gameObject.AddComponent<Cursor>();
            Cursor t_cursor = gameObject.GetComponent<Cursor>();

            yield return new WaitForSeconds(0.1f);
            ScreenSystem t_cursScreenSys = t_cursor.t_screenSystem;
            t_cursor.MoveDown();
            t_cursor.UseFunctionality(t_cursor.currentInvPos);
            t_cursor.MoveRight();
            t_cursor.GoToCharInventory(t_cursor.currentCharPos);

            yield return new WaitForSeconds(0.1f);

            Spells t_spells = GameObject.Find("Magic").GetComponent<Spells>();

            yield return new WaitForSeconds(0.1f);

            Assert.AreEqual("2/2", GameObject.Find("Magic").transform.GetChild(2).Find("Uses").GetComponent<Text>().text);

            t_spells.useSpell();

            yield return new WaitForSeconds(0.1f);

            Assert.AreEqual("1/2", GameObject.Find("Magic").transform.GetChild(2).Find("Uses").GetComponent<Text>().text);
        }

        [UnityTest]
        public IEnumerator Display3WhiteSpells()
        {
            GameObject gameObject = new GameObject();
            gameObject.AddComponent<ScreenSystem>();
            gameObject.AddComponent<RectTransform>();
            ScreenSystem t_system = new ScreenSystem();
            t_system.GoToPauseScreen();

            yield return new WaitForSeconds(0.1f);

            gameObject.AddComponent<Cursor>();
            Cursor t_cursor = gameObject.GetComponent<Cursor>();

            yield return new WaitForSeconds(0.1f);
            ScreenSystem t_cursScreenSys = t_cursor.t_screenSystem;
            t_cursor.MoveDown();
            t_cursor.UseFunctionality(t_cursor.currentInvPos);
            t_cursor.MoveRight();
            t_cursor.GoToCharInventory(t_cursor.currentCharPos);

            yield return new WaitForSeconds(0.1f);

            Spells t_spells = GameObject.Find("Magic").GetComponent<Spells>();

            yield return new WaitForSeconds(0.1f);

            t_spells.AddSpell(SpellType.WhiteSpells);
            yield return new WaitForSeconds(0.1f);
            Assert.AreEqual("Cure", GameObject.Find("Magic").transform.GetChild(2).Find("Spell1").GetComponent<Text>().text);
            t_spells.AddSpell(SpellType.WhiteSpells);
            yield return new WaitForSeconds(0.1f);
            Assert.AreEqual("Cure", GameObject.Find("Magic").transform.GetChild(2).Find("Spell2").GetComponent<Text>().text);
            t_spells.AddSpell(SpellType.WhiteSpells);
            yield return new WaitForSeconds(0.1f);
            Assert.AreEqual("Cure", GameObject.Find("Magic").transform.GetChild(2).Find("Spell3").GetComponent<Text>().text);
        }

        [UnityTest]
        public IEnumerator Display3BlackSpells()
        {
            GameObject gameObject = new GameObject();
            gameObject.AddComponent<ScreenSystem>();
            gameObject.AddComponent<RectTransform>();
            ScreenSystem t_system = new ScreenSystem();
            t_system.GoToPauseScreen();

            yield return new WaitForSeconds(0.1f);

            gameObject.AddComponent<Cursor>();
            Cursor t_cursor = gameObject.GetComponent<Cursor>();

            yield return new WaitForSeconds(0.1f);
            ScreenSystem t_cursScreenSys = t_cursor.t_screenSystem;
            t_cursor.MoveDown();
            t_cursor.UseFunctionality(t_cursor.currentInvPos);
            t_cursor.MoveRight();
            t_cursor.GoToCharInventory(t_cursor.currentCharPos);

            yield return new WaitForSeconds(0.1f);

            Spells t_spells = GameObject.Find("Magic").GetComponent<Spells>();

            yield return new WaitForSeconds(0.1f);

            t_spells.AddSpell(SpellType.BlackSpells);
            yield return new WaitForSeconds(0.1f);
            Assert.AreEqual("Fire", GameObject.Find("Magic").transform.GetChild(2).Find("Spell1").GetComponent<Text>().text);
            t_spells.AddSpell(SpellType.BlackSpells);
            yield return new WaitForSeconds(0.1f);
            Assert.AreEqual("Fire", GameObject.Find("Magic").transform.GetChild(2).Find("Spell2").GetComponent<Text>().text);
            t_spells.AddSpell(SpellType.BlackSpells);
            yield return new WaitForSeconds(0.1f);
            Assert.AreEqual("Fire", GameObject.Find("Magic").transform.GetChild(2).Find("Spell3").GetComponent<Text>().text);
        }
    }
}
