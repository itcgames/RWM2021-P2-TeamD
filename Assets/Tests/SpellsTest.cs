using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class SpellsTest
    {
        [UnityTest]
        public IEnumerator ClassSpecificSpellWhite()
        {
            SceneManager.LoadScene(0);

            yield return new WaitForSeconds(0.1f);

            ScreenSystem t_system = GameObject.FindObjectOfType<ScreenSystem>();

            t_system.GoToCharacterSelcetionScene();

            yield return new WaitForSeconds(0.1f);

            t_system.GoToGameplayScene();

            yield return new WaitForSeconds(0.1f);

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
            SceneManager.LoadScene(0);

            yield return new WaitForSeconds(0.1f);

            ScreenSystem t_system = GameObject.FindObjectOfType<ScreenSystem>();

            t_system.GoToCharacterSelcetionScene();

            yield return new WaitForSeconds(0.1f);

            t_system.GoToGameplayScene();

            yield return new WaitForSeconds(0.1f); ;
            t_system.GoToPauseScreen();

            yield return new WaitForSeconds(0.1f);

            
            Cursor t_cursor =GameObject.FindObjectOfType<Cursor>();

            yield return new WaitForSeconds(0.1f);
            ScreenSystem t_cursScreenSys = t_cursor.t_screenSystem;
            t_cursor.UseFunctionality(t_cursor.currentInvPos);

            Assert.AreEqual(0, t_cursScreenSys.GetCurrentInventory());
        }

        [UnityTest]
        public IEnumerator PickTheWeaponsInventory()
        {
            SceneManager.LoadScene(0);

            yield return new WaitForSeconds(0.1f);

            ScreenSystem t_system = GameObject.FindObjectOfType<ScreenSystem>();

            t_system.GoToCharacterSelcetionScene();

            yield return new WaitForSeconds(0.1f);

            t_system.GoToGameplayScene();

            yield return new WaitForSeconds(0.1f);
            t_system.GoToPauseScreen();

            yield return new WaitForSeconds(0.1f);

            
            Cursor t_cursor = GameObject.FindObjectOfType<Cursor>();

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
            SceneManager.LoadScene(0);

            yield return new WaitForSeconds(0.1f);

            ScreenSystem t_system = GameObject.FindObjectOfType<ScreenSystem>();

            t_system.GoToCharacterSelcetionScene();

            yield return new WaitForSeconds(0.1f);

            t_system.GoToGameplayScene();

            yield return new WaitForSeconds(0.1f);
            t_system.GoToPauseScreen();

            yield return new WaitForSeconds(0.1f);

           
            Cursor t_cursor = GameObject.FindObjectOfType<Cursor>();

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
            SceneManager.LoadScene(0);

            yield return new WaitForSeconds(0.1f);

            ScreenSystem t_system = GameObject.FindObjectOfType<ScreenSystem>();

            t_system.GoToCharacterSelcetionScene();

            yield return new WaitForSeconds(0.1f);

            t_system.GoToGameplayScene();

            yield return new WaitForSeconds(0.1f);
            t_system.GoToPauseScreen();

            yield return new WaitForSeconds(0.1f);

            
            Cursor t_cursor = GameObject.FindObjectOfType<Cursor>();

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
            SceneManager.LoadScene(0);

            yield return new WaitForSeconds(0.1f);

            ScreenSystem t_system = GameObject.FindObjectOfType<ScreenSystem>();

            t_system.GoToCharacterSelcetionScene();

            yield return new WaitForSeconds(0.1f);

            t_system.GoToGameplayScene();

            yield return new WaitForSeconds(0.1f);
            t_system.GoToPauseScreen();

            yield return new WaitForSeconds(0.1f);

            
            Cursor t_cursor = GameObject.FindObjectOfType<Cursor>();

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
