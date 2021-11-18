using System.Collections.Generic;
using UnityEngine;

public class CombatController : MonoBehaviour
{
    private FirstStrikeChance m_firstStrikeScript;

    private Dictionary<int, GameObject> m_battleOrder;

    [SerializeField]
    public List<GameObject> m_party;
    
    public List<GameObject> m_enemies;

    // Start is called before the first frame update
    void Start()
    {
        // run first strike check in start() for now
        StartCombat();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartCombat()
    {
        m_battleOrder = new Dictionary<int, GameObject>();

        m_firstStrikeScript = GetComponent<FirstStrikeChance>();

        if (m_firstStrikeScript.FirstStrikeCheck())
        {
            Debug.Log("You get to strike first.");

            for(int i = 0; i < m_party.Count; ++i)
            {
                m_battleOrder.Add(i + 1, m_party[i]);
            }

            for (int i = 0; i < m_enemies.Count; ++i)
            {
                m_battleOrder.Add(i + m_party.Count + 1, m_enemies[i]);
            }

            foreach (var item in m_battleOrder)
            {
                Debug.Log(item.Key + ": " + item.Value.GetComponent<CharacterAttributes>().Name);
            }
        }
        else
        {
            Debug.Log("Enemies strike first.");

            for (int i = 0; i < m_enemies.Count; ++i)
            {
                m_battleOrder.Add(i + 1, m_enemies[i]);
            }

            for (int i = 0; i < m_party.Count; ++i)
            {
                m_battleOrder.Add(i + m_enemies.Count + 1, m_party[i]);
            }

            foreach (var item in m_battleOrder)
            {
                Debug.Log(item.Key + ": " + item.Value.GetComponent<CharacterAttributes>().Name);
            }
        }
    }
}
