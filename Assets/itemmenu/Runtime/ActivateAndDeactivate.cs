using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateAndDeactivate : MonoBehaviour
{
    public GameObject use;
    public GameObject inventory;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeUse(bool t_set)
    {
        use.SetActive(t_set);
    }
    public void ChangeInventory(bool t_set)
    {
        inventory.SetActive(t_set);
    }

}
