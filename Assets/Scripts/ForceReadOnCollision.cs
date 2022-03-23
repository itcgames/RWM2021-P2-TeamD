using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceReadOnCollision : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
    void OnCollisionEnter2D(Collision2D collision)
    {

        rb = collision.gameObject.GetComponent<Rigidbody2D>();
        if (collision.gameObject.CompareTag("Player"))
        {
          
    float bounce = 6f; //amount of force to apply
            rb.AddForce(collision.contacts[0].normal * bounce);
        }
    }
}
