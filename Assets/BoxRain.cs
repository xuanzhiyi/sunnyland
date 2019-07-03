using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxRain : MonoBehaviour
{
    public GameObject boxes;
    public GameObject cats;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("LaunchProjectile", 2.0f, 2.3f);

        InvokeRepeating("LetCatOut", 2.0f, 10.0f);
    }

    // Update is called once per frame
    void LaunchProjectile()
    {
        Instantiate(boxes, new Vector3(Random.Range(-9.0f, 9.0f), 5, 0), Quaternion.identity);
    }

    void LetCatOut()
    {
        Instantiate(cats, new Vector3(8.0f, -2.5f, 0), Quaternion.identity);
    }
}
