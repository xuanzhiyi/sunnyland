using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rd;

    // Start is called before the first frame update
    void Start()
    {
        rd.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        CatRunning cat = hitInfo.GetComponent<CatRunning>();
        if (cat != null)
        {
            Debug.Log(hitInfo.name);
            cat.die();
        }

        BoxScript box = hitInfo.GetComponent<BoxScript>();
        if(box != null)
        {
            Debug.Log(hitInfo.name);
            box.die();
        }
        Destroy(gameObject);
    }
}
