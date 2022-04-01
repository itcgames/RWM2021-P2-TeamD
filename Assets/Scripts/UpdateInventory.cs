using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UpdateInventory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ItemManager.instance.setAllItems();
    }

}

