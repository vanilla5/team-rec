﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int life;
    private float laserGauge;

    private float angle;

    // Start is called before the first frame update
    void Start()
    {
        life = 3;
        laserGauge = 5;
        angle = 1f / 180f * Mathf.PI;
    }

    // Update is called once per frame
    void Update()
    {
        getInput();
        
    }

    void getInput()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.01f*Mathf.Cos(transform.rotation.y * angle),0, -0.01f * Mathf.Sin(transform.rotation.y * angle));
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.01f*Mathf.Cos(transform.rotation.y * angle), 0, 0.01f * Mathf.Sin(transform.rotation.y * angle));
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0.01f, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -0.01f, 0, 0);
        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("右");
        }
        else if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("左");
        }
    }

    public void increaseLaserGauge()
    {
        laserGauge++;
    }
}
