using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class electronMovement : MonoBehaviour
{
    float speedx;
    float speedy;
    float speedz;
    void Start()
    {
        speedx = Random.Range(40, 120);
        speedy = Random.Range(40, 120);
        speedz = 0;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speedx * Time.deltaTime, speedy * Time.deltaTime, speedz * Time.deltaTime);
    }
}
