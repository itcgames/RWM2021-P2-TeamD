using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatController : MonoBehaviour
{
    private FirstStrikeChance m_firstStrikeScript;
    private List<CharacterAttributes> m_attributeScripts;

    [SerializeField]
    public List<GameObject> m_playableCharacters;

    // Start is called before the first frame update
    void Start()
    {
        m_attributeScripts = new List<CharacterAttributes>();

        for (int i = 0; i < m_playableCharacters.Count; ++i)
        {
            m_attributeScripts.Add(m_playableCharacters[i].GetComponent<CharacterAttributes>());
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
            Debug.Log("You get to strike first.");
        }
        else
        {
            Debug.Log("Enemies strike first.");
        }
    }
}
