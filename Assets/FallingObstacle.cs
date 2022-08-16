using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObstacle : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name.Equals("Sphere"))
        {
            rb.isKinematic = false;
        }
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name.Equals("Sphere"))
        {
            Debug.Log("Collided");
            Debug.Log("My name is Haroon");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
