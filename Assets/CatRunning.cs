using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatRunning : MonoBehaviour
{
    public Rigidbody2D rd;

    // Start is called before the first frame update
    void Start()
    {
        rd.velocity = new Vector2(-4.0f, 0.0f);
    }

    public void die()
    {
        Destroy(gameObject);
    }
}
