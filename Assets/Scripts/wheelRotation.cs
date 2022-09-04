using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelRotation : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform FrontWheel;
    public Transform Backwheel;
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FrontWheel.transform.Rotate(10 * speed * Time.deltaTime, 0, 0);
        Backwheel.transform.Rotate(10 * speed * Time.deltaTime, 0, 0);
    }
}
