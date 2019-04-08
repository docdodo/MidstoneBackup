using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRanged : MonoBehaviour
{
    public GameObject PrimaryFire;
    public GameObject SecondaryFire;
    public GameObject PrimaryFireSpawn;
    public GameObject SecondaryFireSpawn;
    public float primarytimer;
    public float secondarytimer;
    public float primarytimermax;
    public float primarytimermax2;
    public float secondarytimermax;
    public float secondarytimermax2;
    // Start is called before the first frame update
    void Start()
    {
        primarytimer = primarytimermax;
        secondarytimer = secondarytimermax;
    }

    // Update is called once per frame
   
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            primarytimer -= Time.deltaTime;
            if (primarytimer <= 0&&PrimaryFire)
            {
                Instantiate(PrimaryFire, PrimaryFireSpawn.transform.position, PrimaryFireSpawn.transform.rotation);
                primarytimer = secondarytimer = Random.Range(primarytimermax, primarytimermax2);

            }
            secondarytimer -= Time.deltaTime;
            if (secondarytimer <= 0&& SecondaryFire)
            {
                Instantiate(SecondaryFire, SecondaryFireSpawn.transform.position, SecondaryFireSpawn.transform.rotation);
                secondarytimer = Random.Range(secondarytimermax, secondarytimermax2);

            }
        }
    }
}
