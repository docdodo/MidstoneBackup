using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinEnemy : MonoBehaviour
{
    public float damage;
    public float attackspeedmax;
    public float attackspeed;
    public float swordSwing;
    
    public GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        
        swordSwing = 0.5f;
       
    }

    // Update is called once per frame
    void Update()
    {
       
            transform.RotateAround(Enemy.transform.position, Vector3.down, -90 * (Time.deltaTime * 2));
       
       

    }
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            other.GetComponent<Player>().takeDamage(damage);

        }

    }

}
