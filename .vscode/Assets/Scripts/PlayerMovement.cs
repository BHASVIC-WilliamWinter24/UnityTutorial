using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 5f;
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {   
        // check direction to move in
        float h = Input.GetAxis("Horizontal"); 
        float v = Input.GetAxis("Vertical");
        // get current position
        Vector2 pos = transform.position;
        // 
        pos.x += h * speed * Time.deltaTime;
        pos.y += v * speed * Time.deltaTime;

        transform.position = pos;
    }
} // class