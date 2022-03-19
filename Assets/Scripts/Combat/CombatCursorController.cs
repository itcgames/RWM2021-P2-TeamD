using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatCursorController : MonoBehaviour
{
    public GameObject m_cursor;

    public bool DecideAction { get; set; } = false;
    public bool ChoosePartyChar { get; set; } = false;
    public bool ChooseEnemyTarget { get; set; } = false;

    public int CurrentPartyIndex;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AttackAction()
    {
        if (CombatEnum.CombatState.Victory != CombatEnum.s_currentCombatState &&
            CombatEnum.CombatState.Failure != CombatEnum.s_currentCombatState &&
            CombatEnum.CombatState.Escape != CombatEnum.s_currentCombatState)
        {
            ChooseEnemyTarget = true;
        }
    }

    public void RevertAttackAction()
    {
        if (CombatEnum.CombatState.Victory != CombatEnum.s_currentCombatState &&
                   CombatEnum.CombatState.Failure != CombatEnum.s_currentCombatState &&
                   CombatEnum.CombatState.Escape != CombatEnum.s_currentCombatState)
        {
            ChooseEnemyTarget = false;
        }
    }

    public void ItemsAction()
    {
        if (CombatEnum.CombatState.Victory != CombatEnum.s_currentCombatState &&
            CombatEnum.CombatState.Failure != CombatEnum.s_currentCombatState &&
            CombatEnum.CombatState.Escape != CombatEnum.s_currentCombatState)
        {
            // implement items
        }
    }

    public void FleeAction()
    {
        if (!ChooseEnemyTarget)
        {
            if (CombatEnum.CombatState.Victory != CombatEnum.s_currentCombatState &&
            CombatEnum.CombatState.Failure != CombatEnum.s_currentCombatState &&
            CombatEnum.CombatState.Escape != CombatEnum.s_currentCombatState)
            {
                GetComponent<CombatController>().Party[CurrentPartyIndex].GetComponent<ActionController>().Action = ActionController.CombatAction.Flee;
                GetComponent<CombatController>().ChangeActivePartyMember();
            }
        }
    }
}
