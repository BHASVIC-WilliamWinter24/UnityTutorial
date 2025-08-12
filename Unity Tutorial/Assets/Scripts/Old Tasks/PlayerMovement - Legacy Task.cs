using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get the axes of input
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        // the 2D vector is equal to the current position
        Vector2 pos = transform.position;

        pos.x += h * speed * Time.deltaTime;
        pos.y += v * speed * Time.deltaTime;
        // new position is equal to the vector
        transform.position = pos;
    }
}
