﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    Material material;
    Vector2 offset;

    public int xVel, yVel;

    private void Awake()
    {
        material = GetComponent<Renderer>().material;    
    }

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector2(xVel,yVel);
    }

    // Update is called once per frame
    void Update()
    {
        material.mainTextureOffset += offset * Time.deltaTime;
    }
}
