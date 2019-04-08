using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : MonoBehaviour
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
        swordSwing -= Time.deltaTime;
        if (swordSwing > 0)
        {
            transform.RotateAround(Enemy.transform.position, Vector3.down, 90 * (Time.deltaTime * 2));
        }
        else if (swordSwing < 0)
        {
            transform.RotateAround(Enemy.transform.position, Vector3.down, -90 * (Time.deltaTime * 2));
        }
        if (swordSwing < -1)
        {
            swordSwing = 1.0f;
        }

    }
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            other.GetComponent<Player>().takeDamage(damage);

        }

    }

}
