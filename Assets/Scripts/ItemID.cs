using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemID : MonoBehaviour
{
    public int m_ID;
    public int m_cost;
    public string m_name;

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
}
