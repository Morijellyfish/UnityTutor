﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubeup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider Player)
    {
        Player.transform.Translate(0, 0.1f, 0);
    }
}
