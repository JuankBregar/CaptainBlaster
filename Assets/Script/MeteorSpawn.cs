using UnityEngine;

public class MeteorSpawn : MonoBehaviour
{
    public Meteor[] meteorsPrefabs;
    //public GameObject chunks;
    public float minSpawnDelay = 1f;
    public float maxSpawnDelay = 3f;
    public float xLimit = 6f;

    // Start is called before the first frame update
    void Start()
    {

        Spawn();       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        float random = Random.Range(-xLimit, xLimit);
        Vector3 spawnPos = transform.position + new Vector3(random, 0f, 0f);
        //Instantiate(meteorsPrefabs[Random.Range(0, meteorsPrefabs.Length)].prefab, spawnPos, Quaternion.identity);
        Instantiate(GetMeAMeteor(), spawnPos, Quaternion.identity);
        Invoke("Spawn", Random.Range(minSpawnDelay, maxSpawnDelay));
    }

    GameObject GetMeAMeteor()
    {
        //First add current time to all meteor objects
        for (int i = 0; i < meteorsPrefabs.Length; i++)
        {
            meteorsPrefabs[i].currentTime += Time.deltaTime;
        }
        //Pick a random meteor object
        Meteor meteor = meteorsPrefabs[Random.Range(0, meteorsPrefabs.Length)];
        //Check if can be spawned
        if (meteor.isEnabled && meteor.spawnTime <= meteor.currentTime)
        {
            //Set the meteor current time to 0
            meteor.currentTime = 0;
            return meteor.prefab;
        }
        else
            return GetMeAMeteor();

    }
}
