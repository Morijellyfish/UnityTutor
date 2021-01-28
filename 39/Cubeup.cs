using System.Collections;
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
        //範囲にいるときにW押すと上に上がる
       if (Input.GetKey(KeyCode.W))
          {
             transform.Translate(0f, 2f * Time.deltaTime, 0f);
          }
    }
}
