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
        Instantiate(meteorsPrefabs[Random.Range(0,meteorsPrefabs.Length)].prefab, spawnPos, Quaternion.identity);

        Invoke("Spawn", Random.Range(minSpawnDelay, maxSpawnDelay));
    }

    //Chunks for planet explosion
    //void spawnchunks()
    //{
    //    float random = Random.Range(-xLimit, xLimit);
    //    Vector3 spawnPos = transform.position + new Vector3(random, 0f, 0f);
    //    chunks.GetComponent<MeteorMV>().ySpeed = -6;
    //    chunks.GetComponent<MeteorMV>().xSpeed = -6;
    //    Instantiate(chunks, spawnPos, Quaternion.identity);
    //    chunks.GetComponent<MeteorMV>().xSpeed = -3;
    //    Instantiate(chunks, spawnPos, Quaternion.identity);
    //    chunks.GetComponent<MeteorMV>().xSpeed = 0;
    //    Instantiate(chunks, spawnPos, Quaternion.identity);
    //    chunks.GetComponent<MeteorMV>().xSpeed = 3;
    //    Instantiate(chunks, spawnPos, Quaternion.identity);
    //    chunks.GetComponent<MeteorMV>().xSpeed = 6;
    //    Instantiate(chunks, spawnPos, Quaternion.identity);
    //    Invoke("spawnchunks", 10);
    //}

}
