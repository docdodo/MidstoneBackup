using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyMovement : MonoBehaviour
{

    public bool playerSpotted;
    public Transform goal;
   
    Vector3 destination;
    NavMeshAgent agent;
    public void Start()
    {
        agent = GetComponent<NavMeshAgent>();
       
       
    }
   public void OnTriggerStay(Collider other)
    {
        if (agent)
        {
            if (other.gameObject.tag == "Player")
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
