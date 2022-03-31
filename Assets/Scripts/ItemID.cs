using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemID : MonoBehaviour
{
    public int m_ID;
    public int m_cost;
    public int m_amount;
    public string m_name;
    public int m_effects;

    public int getID()
    {
        return m_ID;
    }

    public int getCost()
    {
        return m_cost;
    }
    public string getName()
    {
        return m_name;
    }

    public void addAmount() {

        m_amount++;
    }

    public void removeAmount()
    {
        m_amount--;
    }
    public int getAmount()
    {

        return m_amount;
    }

    public GameObject GetItem()
    {
        return gameObject;
    }

}
