using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion_destroy : MonoBehaviour
{
    public float delay = 3.0f;
    private void FixedUpdate()
    {
        Destroy(gameObject, delay);
    }
}
