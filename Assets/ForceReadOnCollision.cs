using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceReadOnCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag =="Player")
        {
            Vector2 push;
            push.x = 3;
            push.y = 3;
            collision.gameObject.GetComponent<Transform>().position.Set(push.x,push.y, collision.gameObject.GetComponent<Transform>().position.z);          
        }
    }
}
