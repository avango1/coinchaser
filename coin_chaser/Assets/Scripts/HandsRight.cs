using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandsRight : MonoBehaviour
{
    private float speedR;
    void Start()
    {
        speedR = Random.Range(5f, 20);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speedR * Time.deltaTime, 0, 0, Space.World);
        if (transform.position.x < -32)
        {
            speedR = Random.Range(5f, 20);
        }
        if (transform.position.x > -20)
        {
            speedR = -(Random.Range(3f, 10));
        }
    }
}
