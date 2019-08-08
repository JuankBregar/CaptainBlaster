using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public GameObject explosion;
    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
        GetComponent<Rigidbody2D>().velocity = new Vector2(0f, speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.CollisionDestroy(collision.gameObject, explosion);
        Destroy(gameObject);
        gameManager.addScore();
    }
}
