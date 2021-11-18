using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatController : MonoBehaviour
{
    private FirstStrikeChance m_firstStrikeScript;

    private Dictionary<int, GameObject> m_battleOrder;

    [SerializeField]
    public List<GameObject> m_playableCharacters;
    
    public List<GameObject> m_enemies;

    // Start is called before the first frame update
    void Start()
    {
        m_battleOrder = new Dictionary<int, GameObject>();

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
            Debug.Log("You get to strike first.");

            m_battleOrder.Add(1, m_playableCharacters[0]);
            m_battleOrder.Add(2, m_enemies[0]);

            foreach (var item in m_battleOrder)
            {
                Debug.Log(item.Key + ": " + item.Value.GetComponent<CharacterAttributes>().Name);
            }
        }
        else
        {
            Debug.Log("Enemies strike first.");

            m_battleOrder.Add(1, m_enemies[0]);
            m_battleOrder.Add(2, m_playableCharacters[0]);

            foreach (var item in m_battleOrder)
            {
                Debug.Log(item.Key + ": " + item.Value.GetComponent<CharacterAttributes>().Name);
            }
        }

    }
}
