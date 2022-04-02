using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPDisplayController : MonoBehaviour
{
    private float initialHp; // 100% of enemy's hp
    private float HpReduction; // % based
    private float hpScale = 3.25f;
    private float currentHp;

    // Start is called before the first frame update
    void Start()
    {
        HpReduction = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void CalculateReduction(float currentHp)
    {
        float reduction = (initialHp - currentHp) / initialHp * 100;

        HpReduction = (hpScale / 100 * reduction);
    }

    public void UpdateHpBar(EnemySelector enemySelector)
    {
        if ((enemySelector.id - 1) < enemySelector.CombatScript.EnemyList.Count
            && enemySelector.CombatScript.EnemyList[enemySelector.id - 1].activeSelf)
        {
            enemySelector.GetEnemyHP(ref currentHp, ref initialHp);
            CalculateReduction(currentHp);

            transform.GetChild(0).transform.localScale = new Vector2(hpScale - HpReduction,
                transform.GetChild(0).transform.localScale.y);

        }
    }
}
