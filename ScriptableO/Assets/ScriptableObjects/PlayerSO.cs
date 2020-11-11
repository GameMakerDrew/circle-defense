using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "Player")]
public class PlayerSO : ScriptableObject
{
    public int health;
    public float speed;
    public float acceleration;
    public float angularSpeed;
    public Vector3 position;

    public void SubtractHealth(int amount)
    {
        health -= amount;
    }

}
