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
    int selling;
 
    public void Buy()
    {
        m_dialog.text = EventSystem.current.currentSelectedGameObject.GetComponent<ItemID>().getCost().ToString() + "\nGold\nOK?";
        cost = -EventSystem.current.currentSelectedGameObject.GetComponent<ItemID>().getCost();
        m_confirmSelection.SetActive(true);
    }

    public void Sell()
    {
        selling = EventSystem.current.currentSelectedGameObject.GetComponent<ItemID>().getCost() - 3;
        m_dialog.text = selling.ToString() + "\nGold\nOK?";
        m_confirmSelection.SetActive(true);
    }

    public int costProduct()
    {
        return cost;
    }


    public int sellProduct()
    {
        return selling;
    }


}
 