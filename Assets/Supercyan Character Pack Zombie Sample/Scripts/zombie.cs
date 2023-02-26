using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class zombie : MonoBehaviour
{
    public Transform target;
    public NavMeshAgent agent;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            if(agent.hasPath||agent.velocity.sqrMagnitude==0f)
            {
                anim.SetBool("attack", true);
            }
            else
            {
                anim.SetBool("stopped", false);
            }
        }
        else
        {
            anim.SetBool("stopped", false);
        }
    }
}
