using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTurret : MonoBehaviour
{
    public GameObject MissleTarget;
    public bool havetarget;
    public Vector3 Missletarget2;
    public float atkspeed;
    public float Maxatkspeed;
    public float AttackSpeedrate;
    public float Lifetime;
    public GameObject fireP1;
    public GameObject fireP2;
    public GameObject fireP3;
    public GameObject FireBall;
    public GameObject Player;
    
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        Lifetime = Player.GetComponent<Player>().FlameTurretLifeTime;
        Maxatkspeed = 0.6f;
        atkspeed = Maxatkspeed;
        AttackSpeedrate = Player.GetComponent<Player>().FlameTurretAtkSpeedrate;
    }

    // Update is called once per frame
    void Update()
    {
        atkspeed -= (Time.deltaTime*AttackSpeedrate);
        Lifetime-= Time.deltaTime;
        if(Lifetime<=0)
        {
            Destroy(gameObject);
        }
        if (Input.GetButtonDown("Skill2"))
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Enemy")
        {

            MissleTarget = other.gameObject;
            Missletarget2 = MissleTarget.gameObject.transform.position;

            havetarget = true;
            if (havetarget == true)
            {

                transform.LookAt(Missletarget2);
                if(atkspeed<=0)
                {
                    if(fireP1)
                    {
                        Instantiate(FireBall, fireP1.transform.position, fireP1.transform.rotation);
                    }
                    if (fireP2)
                    {
                        Instantiate(FireBall, fireP2.transform.position, fireP2.transform.rotation);
                    }
                    if (fireP3)
                    {
                        Instantiate(FireBall, fireP3.transform.position, fireP3.transform.rotation);
                    }
                    atkspeed = Maxatkspeed;
                }


            }
        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            havetarget = false;
        }
    }
}
