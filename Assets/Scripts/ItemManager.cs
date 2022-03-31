using System.Collections;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{

    public static ItemManager instance;

    public ItemInventory[] items;
    public GameObject buttonPrefab;
    GameObject itemCanvas;


    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(this.gameObject);
    }



    public void setAllItems()
    {
        itemCanvas = GameObject.Find("Itemarea");

        foreach(ItemInventory i in items)
        {
            if(i.m_amount > 0)
            {
                GameObject newButton = Instantiate(buttonPrefab) as GameObject;
                newButton.transform.SetParent(itemCanvas.transform, false);
                newButton.GetComponent<Text>().text = i.m_name + " x" + i.m_amount;
            }
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

    public void UseItem(string name)
    {
        ItemInventory itemAmount = Array.Find(items, items => items.m_name == name);
        if (itemAmount == null)
        {
            Debug.LogWarning("Item: " + name + " not found!");
            return;
        }
        itemAmount.m_amount--;

        print(name + ": " + itemAmount.m_amount);
    }
}
