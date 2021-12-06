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

    GameObject m_itemObject;
    int cost;
    int selling;
 
    public void Buy()
    {
        m_itemObject = EventSystem.current.currentSelectedGameObject.GetComponent<ItemID>().GetItem();
        m_dialog.text = m_itemObject.GetComponent<ItemID>().getCost().ToString() + "\nGold\nOK?";
        cost = m_itemObject.GetComponent<ItemID>().getCost();
        m_confirmSelection.SetActive(true);
    }

    public void Sell()
    {
        selling = m_itemObject.GetComponent<ItemID>().getCost() / 2;
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

    public void addInventory()
    {
        m_itemObject.GetComponent<ItemID>().addAmount();
    }

    public void removeInventory()
    {
        m_itemObject.GetComponent<ItemID>().removeAmount();
    }

    public int GetInventory()
    {
        return m_itemObject.GetComponent<ItemID>().getAmount();
    }


}
