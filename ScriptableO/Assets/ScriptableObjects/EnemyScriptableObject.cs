using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "Enemy")]
public class EnemyScriptableObject : ScriptableObject
{
    public int health;
    public float speed;
    public float acceleration;
    public float angularSpeed;
}
