﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(2f * Time.deltaTime, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.A))
        {

            transform.Translate(-2f * Time.deltaTime, 0f, 0f);
        }
    }
    void OnTriggerStay(Collider Cube)
    {
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 20f * Time.deltaTime, 0f);
        }
    }
}
