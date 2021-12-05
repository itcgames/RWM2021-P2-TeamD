using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCost : MonoBehaviour
{
    [SerializeField]
    private string m_itemName;
    [SerializeField]
    private int m_cost;
    [SerializeField]
    private Text m_dialog;
    [SerializeField]
    GameObject m_confirmSelection;

    GameObject m_player;

    private void Start()
    {
        m_player = GameObject.Find("Player");
    }

    public void Buy()
    {
        m_dialog.text = m_cost.ToString() + "\nGold\nOK?";
        m_confirmSelection.SetActive(true);
    }

    public void costProduct()
    {
        m_player.GetComponent<Player>().setGil(-m_cost);
    }

 
}
 