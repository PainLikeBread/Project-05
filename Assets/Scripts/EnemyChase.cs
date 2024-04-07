using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyChase : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player")){
            Vector3 playerPosition = other.transform.position;
            navMeshAgent.SetDestination(playerPosition);
        }
    }
}
