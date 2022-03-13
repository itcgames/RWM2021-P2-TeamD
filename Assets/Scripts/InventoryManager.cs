using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] private GameObject inventoryCellPrefab;
    [SerializeField] private GameObject inventoryCellParent;

    private List<InventoryCell> inventoryCells;


    void Start()
    {
        inventoryCells = new List<InventoryCell>();
    }

    public void addItem(ItemID item)
    {
        InventoryCell cell = inventoryCells.Find((x) => x.GetItem().getName()
        == item.getName());

        if(cell != null)
        {
            cell.addItemCount(1);
            return;
        }

        GameObject newCell = Instantiate(inventoryCellPrefab,
            inventoryCellParent.transform);
        InventoryCell cellInstance = newCell.GetComponent<InventoryCell>();
        cellInstance.initialize(this);
        cell.SetItem(item);
        inventoryCells.Add(cellInstance);
    }

}
