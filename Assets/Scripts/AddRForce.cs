﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRForce : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Vector3 v3 = new Vector3(0, 10, 0);
            GetComponent<Rigidbody>().AddForce(v3);

        }
        
    }
}
