using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MovementCursorBehavior : MonoBehaviour
{
    public MovementCursorSO MCSO;


    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.onPressedQ += ChangeCursor;
        GameEvents.current.onCursorReset += ToMainCursor;
        GetComponent<MeshFilter>().mesh = MCSO.cursorMesh[0];
    }

    private void Update()
    {
        MoveCursor();
    }

    private void MoveCursor()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Vector3 movPos = new Vector3(hit.point.x, hit.point.y, hit.point.z);
            transform.position = movPos;
            MCSO.position = movPos;
        }
    }

    private void ChangeCursor()
    {
     
    
        GetComponent<MeshFilter>().mesh = MCSO.cursorMesh[1];
    }

    private void ToMainCursor()
    {

   
        GetComponent<MeshFilter>().mesh = MCSO.cursorMesh[0];
    }

}
