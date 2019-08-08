using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetBG : MonoBehaviour
{
    Renderer renderer_;
    public float speed = -2f;
    // Start is called before the first frame update
    void Start()
    {
        renderer_ = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        renderer_.material.mainTextureOffset += new Vector2(0, -(Time.deltaTime * speed));
    }
}
