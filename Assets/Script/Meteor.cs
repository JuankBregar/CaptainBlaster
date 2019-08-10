using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Meteor 
{
    public GameObject prefab;
    public float spawnTime;
    public bool isEnabled;

    public Meteor(GameObject prefab, float spawnTime, bool enabled)
    {
        this.prefab = prefab;
        this.spawnTime = spawnTime;
        this.isEnabled = enabled;
    }
}
