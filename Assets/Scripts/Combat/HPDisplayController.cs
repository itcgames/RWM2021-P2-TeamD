using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPDisplayController : MonoBehaviour
{
    public float InitialHp; // 100% of enemy's hp
    private float HpReduction; // % based
    private float HpScale; // x axis scale
    private float currentHp;

    private EnemySelector m_parentScript;

    // Start is called before the first frame update
    void Start()
    {
        m_parentScript = transform.parent.GetComponent<EnemySelector>();
    }

    // Update is called once per frame
    void Update()
    {
        m_parentScript.GetEnemyHP(ref currentHp, ref InitialHp);

        transform.GetChild(0).transform.localScale = new Vector2(transform.GetChild(0).transform.localScale.x - HpReduction,
            transform.GetChild(0).transform.localScale.y);
    }

    void CalculateReduction(float currentHp)
    {
        float reduction = (InitialHp - currentHp) / InitialHp * 100;

        HpReduction = (transform.GetChild(0).transform.localScale.x / 100 * reduction);
    }
}
