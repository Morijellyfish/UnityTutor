using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prayermove : MonoBehaviour
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
            transform.Translate(5f * Time.deltaTime, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.A))
        {

            transform.Translate(-5f * Time.deltaTime, 0f, 0f);
        }
    }
   
}
