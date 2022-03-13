using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryCell : MonoBehaviour
{

    [SerializeField] private Text ItemName;

    private ItemID currentItem;
    private int count;


    public void initialize(InventoryManager inventoryManager)
    {
        Debug.Log("AAAA");
    }

    public void addItemCount(int amount)
    {
        count+= amount;
        ItemName.text = ($"{currentItem.getName()} {count}x");
    }

    public void SetItem(ItemID itemSet)
    {   
        count = 1;
        currentItem = itemSet;
        ItemName.text = ($"{currentItem.getName()} {count}x");
    }

    public GameObject getCellInstance() { return gameObject; }
    public ItemID GetItem() { return currentItem; }
    public int GetCount() { return count; }
    public void RemoveCell() { Destroy(gameObject); }

}
