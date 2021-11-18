using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatController : MonoBehaviour
{
    private FirstStrikeChance m_firstStrikeScript;
    private List<CharacterAttributes> m_partyAttrs;
    private List<CharacterAttributes> m_enemyAttrs;

    private Dictionary<int, CharacterAttributes> m_battleOrder;

    [SerializeField]
    public List<GameObject> m_playableCharacters;
    
    public List<GameObject> m_enemies;

    // Start is called before the first frame update
    void Start()
    {
        m_battleOrder = new Dictionary<int, CharacterAttributes>();

        m_partyAttrs = new List<CharacterAttributes>();
        m_enemyAttrs = new List<CharacterAttributes>();

        for (int i = 0; i < m_playableCharacters.Count; ++i)
        {
            m_partyAttrs.Add(m_playableCharacters[i].GetComponent<CharacterAttributes>());
        }

        m_firstStrikeScript = GetComponent<FirstStrikeChance>();

        // run first strike check in start() for now
        StartCombat();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartCombat()
    {
        if (m_firstStrikeScript.FirstStrikeCheck())
        {
            //Debug.Log("You get to strike first.");
        }
        else
        {
            //Debug.Log("Enemies strike first.");
        }

        m_battleOrder.Add(1, m_partyAttrs[0]);
        m_battleOrder.Add(2, m_enemies[0].GetComponent<CharacterAttributes>());

        foreach (var item in m_battleOrder)
        {
            Debug.Log(item.Key + ": " + item.Value.Name);
        }
    }
}
