using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBehavior : MonoBehaviour
{
    public ActorListSO ALSO;

    [SerializeField] private TowerSO TSO;

    private int count = 0;
    private int health;
    private int attackSpeed;
    private int power;
    private int range;
    private int attackIndex;

    private GameObject projectile;

    private GameObject[] attackable = new GameObject[10];

    private GameObject turretHead;

    // Start is called before the first frame update
    void Start()
    {
        health = TSO.health;
        attackSpeed = TSO.attackSpeed;
        power = TSO.power;
        range = TSO.range;
        projectile = TSO.projectile;
        turretHead = transform.GetChild(3).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
            RotateToClosestEnemy();
        
       
    }

    private void RotateToClosestEnemy()
    {
        float tempDist = 1000;
        int i = 0;
        int z = 0;
        foreach (GameObject enemy in ALSO.enemies)
        {
            float dist = Vector3.Distance(transform.position, enemy.transform.position);
            if (dist < tempDist)
            {
                z = i;
                tempDist = dist;
            }
            i++;
        }

        if (tempDist < range)
        {
            turretHead.transform.rotation = Quaternion.LookRotation(ALSO.enemies[z].transform.position - transform.position);
            var th = Instantiate(TSO.projectile, turretHead.transform.position, new Quaternion(0, 0, 0, 0));
            th.GetComponent<Rigidbody>().velocity = ALSO.enemies[z].transform.position - transform.position;

            //TODO: Make it not call instantiate every 
        }
        
    }
}
