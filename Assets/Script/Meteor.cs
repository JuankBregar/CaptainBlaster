using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Meteor 
{
    public GameObject prefab;
    public float spawnTime;
    public bool isEnabled;
    [System.NonSerialized]
    public float currentTime = 0;
}
