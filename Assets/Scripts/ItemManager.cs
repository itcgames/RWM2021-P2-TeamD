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
    public Text textPrefab;
    GameObject itemCanvas;
    GameObject desc;
    Text desc1;
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
        desc = GameObject.Find("Description");


        foreach (ItemInventory i in items)
        {
            i.m_amount++;
            if (i.m_amount > 0)
            {
                GameObject newButton = Instantiate(buttonPrefab) as GameObject;

                newButton.transform.SetParent(itemCanvas.transform, false);
                newButton.GetComponent<Text>().text = i.m_name + " x" + i.m_amount;
                if (SceneManager.GetActiveScene().name == "Pause")
                {
                    newButton.GetComponent<Button>().onClick.AddListener(() => {
                        ChangeDesc(i.m_desc);
                    });

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


    public void AddItem(string t_name)
    {
        ItemInventory itemDetail = Array.Find(items, items => items.m_name == t_name);
        if (itemDetail == null)
        {
            Debug.LogWarning("Item: " + name + " not found!");
            return;
        }

        itemDetail.m_amount++;
    }

    public void UseItem(string t_name)
    {
        ItemInventory itemDetail = Array.Find(items, items => items.m_name == name);
        if (itemDetail == null)
        {
            Debug.LogWarning("Item: " + name + " not found!");
            return;
        }
        itemDetail.m_amount--;

        print(t_name + ": " + itemDetail.m_amount);
        print(t_name + ": " + itemDetail.m_desc);
    }

    public void ChangeDesc(string t_desc)
    {
        if (desc1 == null)
        {
            desc1 = Instantiate(textPrefab) as Text;

            desc1.transform.SetParent(desc.transform, false);
            desc1.transform.position = desc.transform.position;
        }

        desc1.text = t_desc;


    }
}
