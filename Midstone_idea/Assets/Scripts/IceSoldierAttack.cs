using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSoldierAttack : MonoBehaviour
{
    public float damage;
    public float attackspeedmax;
    public float attackspeed;
    public float swordSwing;
    public GameObject player;
    public GameObject IceSoldier;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        swordSwing = 0.5f;
        damage = player.GetComponent<Player>().IceSoldierDamage;
    }

    // Update is called once per frame
    void Update()
    {
        swordSwing -= Time.deltaTime;
        if(swordSwing>0)
            {
            transform.RotateAround(IceSoldier.transform.position, Vector3.down, 90 * (Time.deltaTime*2));
        }
        else if(swordSwing<0)
        {
            transform.RotateAround(IceSoldier.transform.position, Vector3.down, -90 * (Time.deltaTime*2));
        }
        if(swordSwing<-1)
        {
            swordSwing = 1.0f;
        }
       
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            other.GetComponent<Health>().changeHP(-damage);

        }

    }

    }
