using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Tower", menuName = "Tower")]
public class TowerSO : ScriptableObject
{
    public int health;
    public float attackSpeed;
    public int power;
    public int range;

    public GameObject projectile;
}


