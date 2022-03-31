using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XpBarController : MonoBehaviour
{
    private float xpThreshold; // 100% of enemy's hp
    private float XpReduction; // % based
    private float xpScale = 3.2498f;
    private float currentXp;

    // Start is called before the first frame update
    void Start()
    {
        XpReduction = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void CalculateReduction(float currentHp)
    {
        float reduction = (xpThreshold - currentHp) / xpThreshold * 100;

        XpReduction = (xpScale / 100 * reduction);
    }

    public void UpdateXpBar(GameObject partyMember)
    {
        xpThreshold = partyMember.GetComponent<CharacterAttributes>().LevelUpThreshold;
        currentXp = partyMember.GetComponent<CharacterAttributes>().Xp;

        CalculateReduction(currentXp);

        transform.GetChild(0).transform.localScale = new Vector2(xpScale - XpReduction,
            transform.GetChild(0).transform.localScale.y);
    }
}
