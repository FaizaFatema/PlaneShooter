using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public Renderer meshRender;
    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // Vector2 ofset = meshRender.material.mainTextureOffset;
        //ofset = ofset + new Vector2(0, speed * Time.deltaTime);
        //meshRender.material.mainTextureOffset = ofset;

        meshRender.material.mainTextureOffset += new Vector2(0, speed * Time.deltaTime);
    }
}
