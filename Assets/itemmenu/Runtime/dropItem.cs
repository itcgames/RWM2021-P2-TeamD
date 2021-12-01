using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropItem : MonoBehaviour
{
    public GameObject Item;
    public bool drop;
    // Start is called before the first frame update
    void Start()
    {
    }
    private void OnDisable()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
     
    }
    public void droping()
    {
        Destroy(Item);
    }
}
