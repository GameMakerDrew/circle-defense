using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Cursor" , menuName = "Cursor")]
public class MovementCursorSO : ScriptableObject
{
    public Vector3 scale;
    public Vector3 position;
    public Mesh[] cursorMesh;

}
