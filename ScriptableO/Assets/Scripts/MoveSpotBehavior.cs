using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpotBehavior : MonoBehaviour
{
    public MovementCursorSO MCSO;
 
    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.onRightClick += MoveSpot;
    }

    private void OnDisable()
    {
        GameEvents.current.onRightClick -= MoveSpot;
    }



    private void MoveSpot()
    {
        transform.position = MCSO.position;
    }
}
