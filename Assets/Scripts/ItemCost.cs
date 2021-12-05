using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemCost : MonoBehaviour
{
    [SerializeField]
    private Text m_dialog;
    [SerializeField]
    GameObject m_confirmSelection;

    int cost;
 
    public void Buy()
    {
        m_dialog.text = EventSystem.current.currentSelectedGameObject.GetComponent<ItemID>().getCost().ToString() + "\nGold\nOK?";
        cost = -EventSystem.current.currentSelectedGameObject.GetComponent<ItemID>().getCost();
        m_confirmSelection.SetActive(true);
    }

    public int costProduct()
    {
        return cost;
    }

 
}
 