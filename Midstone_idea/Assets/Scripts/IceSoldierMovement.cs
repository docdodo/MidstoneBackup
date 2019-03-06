using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class IceSoldierMovement : MonoBehaviour
{
    public GameObject player;
    public Transform goal;
    public float lifeSpan;
    
    Vector3 destination;
    NavMeshAgent agent;
    public void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        player = GameObject.Find("Player");
        lifeSpan = player.GetComponent<Player>().IceSoldierLifespan;
        
    }
    void Update()
    {
        lifeSpan -= Time.deltaTime;
        if(lifeSpan<0)
        {
            Destroy(gameObject);
        }
        
    }
    public void OnTriggerStay(Collider other)
    {
        if (agent)
        {
            if (other.gameObject.tag == "Enemy")
            {


                goal = other.gameObject.transform;
                destination = goal.position;
                if (agent)
                {
                    agent.destination = destination;
                }
                else if (!agent) { }


            }
        }
        else if (!agent) { }
    }



}
