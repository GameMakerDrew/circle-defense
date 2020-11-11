using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasBehavior : MonoBehaviour
{
    public PlayerSO PSO;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        GetComponentInChildren<Text>().text = PSO.health.ToString();
    }
}
