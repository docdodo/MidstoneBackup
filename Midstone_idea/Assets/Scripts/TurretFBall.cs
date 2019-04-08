using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretFBall : MonoBehaviour
{
    Rigidbody rb;
    public float timer;
    
    public float speed;
    public float damage;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        damage = player.GetComponent<Player>().FlameTurretdamage;
        timer = 3.0f;
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        rb.velocity = transform.forward * speed;
        if (timer <= 0.0f)
        {
          
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Enemy")
        {
            other.GetComponent<Health>().changeHP(-damage);
           
            Destroy(this.gameObject);

        }
        else if (other.gameObject.tag == "Ground")
        {
            Destroy(this.gameObject);
        }
    }
}


