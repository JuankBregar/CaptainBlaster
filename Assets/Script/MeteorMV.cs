using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMV : MonoBehaviour
{
    public float xSpeed = 0f;
    public float ySpeed = -2f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(xSpeed, ySpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
