﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMissle2 : MonoBehaviour
{
    float timer;
    // Start is called before the first frame update
    void Awake()
    {
        timer = 4.0f;
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

        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<Player>().takeDamage(10.0f);
            Destroy(transform.parent.gameObject);
            Destroy(this.gameObject);

        }
        else if (other.gameObject.tag == "Ground")
        {
            Destroy(transform.parent.gameObject);
        }
    }
}