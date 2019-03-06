using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRanged : MonoBehaviour
{
    public GameObject PrimaryFire;
    public GameObject PrimaryFireSpawn;
    public float primarytimer;
    public float primarytimermax;
    // Start is called before the first frame update
    void Start()
    {
        primarytimer = primarytimermax;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            primarytimer -= Time.deltaTime;
            if (primarytimer <= 0)
            {
                Instantiate(PrimaryFire, PrimaryFireSpawn.transform.position, PrimaryFireSpawn.transform.rotation);
                primarytimer = primarytimermax;

            }

        }
    }
}
