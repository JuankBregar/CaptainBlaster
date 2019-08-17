using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public GameManager gameManager;
    //public GameObject bulletPrefab;
    public Meteor[] bulletPrefab;
    public GameObject explosionPrefab;
    public float speed = 10f;
    public float xLimit = 7f;
    //public float reloadTime = 0.5f;
    //float elapsedTime = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Track firing time
        //elapsedTime += Time.deltaTime;
        //Move the player on x axis
        float xInput = Input.GetAxis("Horizontal");
        transform.Translate(xInput * speed * Time.deltaTime, 0f, 0f);
        //Clamp player x position
        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, -xLimit, xLimit);
        transform.position = position;
        //Fire
        Fire();
    }

    //End game
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "bullet" && collision.tag != "rocket")
        {
            gameManager.CollisionDestroy(gameObject, explosionPrefab);
            gameManager.playerDied();
        }
    }


    void Fire()
    {
        //Add current time to all bullets
        for (int i = 0; i < bulletPrefab.Length; i++)
        {
            bulletPrefab[i].currentTime += Time.deltaTime;
        }

        if (Input.GetButtonDown("Jump") && bulletPrefab[0].spawnTime <= bulletPrefab[0].currentTime && bulletPrefab[0].isEnabled)
        {
            Vector3 spawnPos = transform.position;
            spawnPos += new Vector3(0, 1.2f, 0);
            Instantiate(bulletPrefab[0].prefab, spawnPos, Quaternion.identity);
            bulletPrefab[0].currentTime = 0f; 
        }

        if (Input.GetKeyDown(KeyCode.Z) && bulletPrefab[1].spawnTime <= bulletPrefab[1].currentTime && bulletPrefab[1].isEnabled)
        {
            Vector3 spawnPos = transform.position;
            spawnPos += new Vector3(0, 1.2f, 0);
            Instantiate(bulletPrefab[1].prefab, spawnPos, Quaternion.identity);
            bulletPrefab[1].currentTime = 0f;
        }
    }

}
