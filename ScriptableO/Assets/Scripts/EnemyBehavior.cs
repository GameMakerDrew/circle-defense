using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : MonoBehaviour
{
    private NavMeshAgent NMA;
    public EnemyScriptableObject ESO;
    public PlayerSO PSO;
    private int health;
    // Start is called before the first frame update
    void Start()
    {

        NMA = GetComponent<NavMeshAgent>();
        
  
    
    }

    // Update is called once per frame
    void Update()
    {
        //TODO: If player is inside of enemy range setDest Player Else SETDEST home
        NMA.SetDestination(PSO.position);
        NMA.speed = ESO.speed;
        NMA.acceleration = ESO.acceleration;
        NMA.angularSpeed = ESO.angularSpeed;
        health = ESO.health;
    }
}
