﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 10f;
    public float Padding = 0.8f;
    float minx;
    float maxX;
    float minY;
    float maxY;
    // Start is called before the first frame update
    void Start()
    {
        FindBoundries();
        
    }
    void FindBoundries()
    {
        Camera gameCamera = Camera.main;
        minx = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x+Padding;
        maxX = gameCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x-Padding;
        minY = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + Padding;
        maxY = gameCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - Padding;
    }
    
    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float deltaY = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        float newXpos = Mathf.Clamp(transform.position.x + deltaX, minx, maxX);
        float newYpos =Mathf.Clamp(transform.position.y + deltaY,minY,maxY);
       
        transform.position = new Vector2(newXpos,newYpos);
        
    }
}
