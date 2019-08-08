using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject bulletPrefab;
    public GameObject explosionPrefab;
    public float speed = 10f;
    public float xLimit = 7f;
    public float reloadTime = 0.5f;
    float elapsedTime = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Track firing time
        elapsedTime += Time.deltaTime;
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
        gameManager.CollisionDestroy(gameObject, explosionPrefab);
        gameManager.playerDied();
    }


    void Fire()
    {
        if(Input.GetButtonDown("Jump")&& elapsedTime > reloadTime)
        {
            Vector3 spawnPos = transform.position;
            spawnPos += new Vector3(0, 1.2f, 0);
            Instantiate(bulletPrefab, spawnPos, Quaternion.identity);
            elapsedTime = 0f; 
        }
    }

}
