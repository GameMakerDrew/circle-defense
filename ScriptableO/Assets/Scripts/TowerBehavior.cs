using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBehavior : MonoBehaviour
{
    public ActorListSO ALSO;

    [SerializeField] private TowerSO TSO;

    private int health;
    private float attackSpeed;
    private int power;
    private int range;
    private int attackIndex;

    private GameObject projectile;

    private GameObject turretHead;





    private GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        health = TSO.health;
        attackSpeed = TSO.attackSpeed;
        power = TSO.power;
        range = TSO.range;
        projectile = TSO.projectile;
        turretHead = transform.GetChild(3).gameObject;
        InvokeRepeating("FindClosestTarget", 0f, 1f);

    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            return;
        }

        RotateToTarget();
    }

    private void FindClosestTarget()
    {
        float shortestDist = Mathf.Infinity;
        GameObject nearestEnemy = null;
        foreach (GameObject enemy in ALSO.enemies)
        {
            float testDist = Vector3.Distance(transform.position, enemy.transform.position);
            if (testDist < shortestDist)
            {
                nearestEnemy = enemy;
                shortestDist = testDist;
            }
        }

        if (nearestEnemy != null && shortestDist <= range)
        {
            target = nearestEnemy;
        }
        else
        {
            target = null;
        }

    }

    private void RotateToTarget()
    {
        turretHead.transform.LookAt(new Vector3(target.transform.position.x, turretHead.transform.position.y, target.transform.position.z));
    }



}
