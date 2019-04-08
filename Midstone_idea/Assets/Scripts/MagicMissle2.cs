using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicMissle2 : MonoBehaviour
{
    public bool IceBarrage;
    public float timer;
    public float damage;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        damage = player.GetComponent<Player>().IceMissledamage;
        IceBarrage = player.GetComponent<Player>().IceBarrage;
       if(IceBarrage)
        {
            damage = damage * 0.75f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0.0f)
        {
            Destroy(transform.parent.gameObject);
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Enemy")
        {
            other.GetComponent<Health>().changeHP(-damage);
            Destroy(transform.parent.gameObject);
            Destroy(this.gameObject);

        }
        else if(other.gameObject.tag =="Ground")
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
