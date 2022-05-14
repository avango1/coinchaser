using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandsLeft : MonoBehaviour
{
    public float speed;
    void Start()
    {
        speed = Random.Range(5f, 20);
    }
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0, Space.World);
        if (transform.position.x > 30)
        {
            speed = -(Random.Range(5f, 20));
        }
        if (transform.position.x < 20)
        {
            speed = Random.Range(7f,10);
        }
    }
}
