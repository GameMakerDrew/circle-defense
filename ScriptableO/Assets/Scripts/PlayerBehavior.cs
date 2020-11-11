using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerBehavior : MonoBehaviour
{
    
    public PlayerSO PSO;
    public MovementCursorSO cursor;

    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.onRightClick += MoveOnClick;
    }

    private void OnDisable()
    {
        GameEvents.current.onRightClick -= MoveOnClick;
    }

    // Update is called once per frame
    void Update()
    {
        PSO.position = transform.position;
        
        GetComponent<NavMeshAgent>().speed = PSO.speed;
        GetComponent<NavMeshAgent>().acceleration = PSO.acceleration;
        GetComponent<NavMeshAgent>().acceleration = PSO.angularSpeed;
    }

    private void FixedUpdate()
    {
       
    }

    void MoveOnClick()
    {
        Debug.Log("OnCLick");
        GetComponent<NavMeshAgent>().SetDestination(cursor.position);
    }
}
