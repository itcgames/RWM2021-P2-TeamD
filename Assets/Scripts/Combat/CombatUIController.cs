using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombatUIController : MonoBehaviour
{
    public Text[] m_nameTextList;
    public Text[] m_hpTextList;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetupNameTexts(List<GameObject> party)
    {
        for (int i = 0; i < party.Count; i++)
        {
            m_nameTextList[i].text = party[i].GetComponent<CharacterAttributes>().Name.ToString();
        }
    }

    public void UpdateHpTexts(List<GameObject> party)
    {
        for (int i = 0; i < party.Count; i++)
        {
            if (!party[i].activeSelf) m_hpTextList[i].text = "0";
            else m_hpTextList[i].text = party[i].GetComponent<CharacterAttributes>().FindAttribute("HP").Value.ToString();
        }
    }
}
