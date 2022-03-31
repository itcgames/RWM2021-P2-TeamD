using System.Collections;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

public class ItemManager : MonoBehaviour
{

    public static ItemManager instance;

    public ItemInventory[] items;
    public GameObject buttonPrefab;
    GameObject itemCanvas;
    
    public GameObject PlayerInfo;

    private void Awake()
    {
        PlayerInfo = GameObject.Find("SceneManager");
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


        foreach (ItemInventory i in items)
        {
            if(i.m_amount > 0)
            {
                GameObject newButton = Instantiate(buttonPrefab) as GameObject;
                newButton.transform.SetParent(itemCanvas.transform, false);
                newButton.GetComponent<Text>().text = i.m_name + " x" + i.m_amount;

                if (SceneManager.GetActiveScene().name == "Pause")
                {
                    newButton.GetComponent<Button>().onClick.AddListener(() => {
                        print("inventory rn");
                    });
                    //using item;
                }
                else if (SceneManager.GetActiveScene().name == "ItemShop")
                {
                    newButton.GetComponent<Button>().onClick.AddListener(() => {

                        if (i.m_amount > 1)
                        {
                            i.m_amount--;
                            newButton.GetComponent<Text>().text = i.m_name + " x" + i.m_amount;
                        }
                        else
                        {
                            Destroy(newButton);
                        }
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_gil += i.m_cost / 2;
                    });

                }
                else
                {
                    print("nothing");
                }
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
