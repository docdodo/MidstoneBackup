using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMissle3 : MonoBehaviour
{

    
    public float speed;
    Rigidbody rb;
    void Awake()
    {
       
        rb = GetComponent<Rigidbody>();



    }

    void Update()
    {



        Debug.DrawRay(transform.position, transform.forward);
        rb.velocity = transform.forward * speed;



    }
    
}
