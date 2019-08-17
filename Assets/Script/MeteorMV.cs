using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMV : MonoBehaviour
{
    public float xSpeed = 0f;
    public float maxYSpeed = -2f;
    public float minYSpeed = -2f;
    float fixedSpeed = -2f;
    public int points = 1;
    // Start is called before the first frame update
    void Start()
    {
        if (tag == "meteor")
            GetComponent<Rigidbody2D>().velocity = new Vector2(xSpeed, Random.Range(minYSpeed, maxYSpeed));
    }

    // Update is called once per frame
    void Update()
    {
        if (tag == "planet")
            this.transform.Translate(0f, fixedSpeed * Time.deltaTime, 0f);
    }
}
