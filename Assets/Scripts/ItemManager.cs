using System.Collections;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class ItemManager : MonoBehaviour
{

    public static ItemManager instance;

    public ItemInventory[] items;


    private void Awake()
    {

        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
    }



    public void setAllItems()
    {
        foreach(ItemInventory i in items)
        {



        }
    }


    public void AddItem(string name)
    {
        ItemInventory itemAmount = Array.Find(items, items => items.m_name == name);
        if (itemAmount == null)
        {
            Debug.LogWarning("Item: " + name + " not found!");
            return;
        }
        itemAmount.m_amount++;

        print(name + ": " + itemAmount.m_amount);
    }
}
