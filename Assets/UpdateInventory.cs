using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateInventory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ItemManager.instance.setAllItems();
    }

}
