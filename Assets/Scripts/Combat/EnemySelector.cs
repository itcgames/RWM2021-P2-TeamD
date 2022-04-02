using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySelector : MonoBehaviour
{
    public CombatController CombatScript;
    private CombatCursorController m_combatCursorScript;
    public int id;

    // Start is called before the first frame update
    void Start()
    {
        Physics2D.queriesStartInColliders = true;
        Physics2D.queriesHitTriggers = true;

        CombatScript = GameObject.Find("CombatSystem").GetComponent<CombatController>();
        m_combatCursorScript = GameObject.Find("CombatSystem").GetComponent<CombatCursorController>();
    }

    private void Update()
    {
        if ((id - 1) < CombatScript.EnemyList.Count)
        {
            if (!CombatScript.EnemyList[id - 1].activeSelf)
            {
                transform.GetChild(0).gameObject.SetActive(false);
                return;
            }
        }

        if (!transform.GetChild(0).gameObject.activeSelf && (id - 1) < CombatScript.EnemyList.Count)
        {

            transform.GetChild(0).gameObject.SetActive(true);
        }

    }

    public void OnMouseDown()
    {
        if (m_combatCursorScript.ChooseEnemyTarget)
        {
            if (CombatScript.EnemyList[id - 1].activeSelf)
            {
                Debug.Log("Enemy: " + id + " selected");
                CombatScript.Party[m_combatCursorScript.CurrentPartyIndex].GetComponent<ActionController>().Action = ActionController.CombatAction.Fight;
                CombatScript.Party[m_combatCursorScript.CurrentPartyIndex].GetComponent<ActionController>().Target = CombatScript.EnemyList[id - 1];
                CombatScript.Party[m_combatCursorScript.CurrentPartyIndex].GetComponent<ActionController>().TargetInitPos = CombatScript.EnemyInitPositions[id - 1];
                CombatScript.Party[m_combatCursorScript.CurrentPartyIndex].GetComponent<ActionController>().StatusTxt = CombatScript.m_statusTxt;

                CombatScript.ChangeActivePartyMember();
                m_combatCursorScript.ChooseEnemyTarget = false;
            }
        }
    }

    public void GetEnemyHP(ref float hp, ref float maxHp)
    {
        if ((id - 1) < CombatScript.EnemyList.Count)
        {
            hp = CombatScript.EnemyList[id - 1].GetComponent<CharacterAttributes>().FindAttribute("HP").Value;
            maxHp = CombatScript.EnemyList[id - 1].GetComponent<CharacterAttributes>().FindAttribute("MHP").Value;

            Debug.Log("Enemy " + id + " HP: " + hp + "/" + maxHp);
        }
    }
}
