using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public ActorListSO ALSO; 
    public GameObject[] enemyList;
    public GameObject[] towerList;
    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.onActorAdded += UpdateList;
        enemyList = GameObject.FindGameObjectsWithTag("Enemy");
        towerList = GameObject.FindGameObjectsWithTag("Tower");
        ALSO.enemies = enemyList;
        ALSO.towers = towerList;
    }

    private void UpdateList()
    {
        enemyList = GameObject.FindGameObjectsWithTag("Enemy");
        towerList = GameObject.FindGameObjectsWithTag("Tower");
        ALSO.enemies = enemyList;
        ALSO.towers = towerList;
    }


}
