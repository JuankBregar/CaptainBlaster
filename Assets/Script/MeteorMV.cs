using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMV : MonoBehaviour
{
    public float speed = -2f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
