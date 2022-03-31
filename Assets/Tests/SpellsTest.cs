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
    }
}
