using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ActorList", menuName = "ActorList")]
public class ActorListSO : ScriptableObject
{
    public GameObject[] enemies;
    public GameObject[] towers;
}
