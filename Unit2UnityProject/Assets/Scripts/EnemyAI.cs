using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    //Define Variables
    public GameObject enemyTarget;
    NavMeshAgent enemyAgent;
    public GameObject enemy;
    
    void Start()
    {
        enemyAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyAgent.SetDestination(enemyTarget.transform.position);
    }  
}
