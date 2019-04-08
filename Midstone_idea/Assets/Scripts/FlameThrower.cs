using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrower : MonoBehaviour
{
    public GameObject player;
    public float damage;
    public float lifestealamount;
    void OnTriggerStay(Collider other)
    {
        

        if (other.gameObject.tag == "Enemy")
        {
            damage = player.GetComponent<Player>().FlameThrowerdamage;
           lifestealamount = player.GetComponent<Player>().FlameThrowerlifesteal;
            other.GetComponent<Health>().changeHP(-damage);
            player.GetComponent<Player>().Heal(damage*lifestealamount);

        }
    }
}
