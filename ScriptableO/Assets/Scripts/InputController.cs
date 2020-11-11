using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public GameEvents ga;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(1))
        {
            Debug.Log("MBUp");
            GameEvents.current.RightClick();
        }

        else if (Input.GetKeyDown(KeyCode.Q))
        {
            GameEvents.current.PressedQ();
        }
        else if (Input.GetKeyUp(KeyCode.Q))
        {
            GameEvents.current.CursorReset();
        }

        
    }
}
