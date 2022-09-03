using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public float speed;
    public float y_speed;
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speed * Time.deltaTime, y_speed * Time.deltaTime, 0);
    }
}
