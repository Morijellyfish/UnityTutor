using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRForce : MonoBehaviour
{
    [SerializeField] Vector3 force;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddRelativeForce(force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
