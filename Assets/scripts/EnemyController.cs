using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{

    public float LookRadius = 10f;
    public Transform target;
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if(distance <= LookRadius)
        {
            agent.SetDestination(target.position);
        }
    }
    void OnDrawGizmosSelected()
    {
    Gizmos.color = Color.red;
    Gizmos.DrawWireSphere(transform.position, LookRadius);
    }
    
}
