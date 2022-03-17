using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySelector : MonoBehaviour
{
    private CombatController m_combatScript;
    private CombatCursorController m_combatCursorScript;
    public int id;

    // Start is called before the first frame update
    void Start()
    {
        m_combatScript = GameObject.Find("CombatSystem").GetComponent<CombatController>();
        m_combatCursorScript = GameObject.Find("CombatSystem").GetComponent<CombatCursorController>();
    }

    private void OnMouseDown()
    {
        if (m_combatCursorScript.ChooseEnemyTarget)
        {
            if(m_combatScript == null)
            {
                Debug.Log("oof");
            }

            Debug.Log("Enemy: " + id + " selected");
            m_combatScript.Party[m_combatCursorScript.CurrentPartyIndex].GetComponent<ActionController>().Action = ActionController.CombatAction.Fight;
            m_combatScript.Party[m_combatCursorScript.CurrentPartyIndex].GetComponent<ActionController>().Target = m_combatScript.EnemyList[id - 1];

            m_combatScript.ChangeActivePartyMember();
            m_combatCursorScript.ChooseEnemyTarget = false;
        }
    }
}
