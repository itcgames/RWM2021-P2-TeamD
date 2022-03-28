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
        Physics2D.queriesStartInColliders = true;
        Physics2D.queriesHitTriggers = true;

        m_combatScript = GameObject.Find("CombatSystem").GetComponent<CombatController>();
        m_combatCursorScript = GameObject.Find("CombatSystem").GetComponent<CombatCursorController>();
    }

    private void Update()
    {
        if ((id - 1) < m_combatScript.EnemyList.Count)
        {
            if (!m_combatScript.EnemyList[id - 1].activeSelf)
            {
                transform.GetChild(0).gameObject.SetActive(false);
                return;
            }
        }

        if (!transform.GetChild(0).gameObject.activeSelf && (id - 1) < m_combatScript.EnemyList.Count)
        {

            transform.GetChild(0).gameObject.SetActive(true);
        }

    }

    public void OnMouseDown()
    {
        if (m_combatCursorScript.ChooseEnemyTarget)
        {
            if (m_combatScript.EnemyList[id - 1].activeSelf)
            {
                Debug.Log("Enemy: " + id + " selected");
                m_combatScript.Party[m_combatCursorScript.CurrentPartyIndex].GetComponent<ActionController>().Action = ActionController.CombatAction.Fight;
                m_combatScript.Party[m_combatCursorScript.CurrentPartyIndex].GetComponent<ActionController>().Target = m_combatScript.EnemyList[id - 1];

                m_combatScript.ChangeActivePartyMember();
                m_combatCursorScript.ChooseEnemyTarget = false;
            }
        }
    }
}
