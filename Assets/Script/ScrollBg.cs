using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBg : MonoBehaviour
{
    public float speed = -2f;
    public float lowerYValue = -20f;
    public float upperYValue = 40;
    public bool invert = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Transalate on Y
        //transform.Translate(0f, speed * Time.deltaTime, 0f);
        //Transalate on X
        transform.Translate(invert?-(speed * Time.deltaTime):speed*Time.deltaTime, 0f, 0f);
        if (transform.position.y <= lowerYValue)
            //transform.Translate(0f, upperYValue, 0f);
            transform.Translate(invert?-upperYValue:upperYValue, 0f, 0f);
    }
}
