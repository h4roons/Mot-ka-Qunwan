using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    public static Drag instance;
    private Touch touch;
    [SerializeField]private float speedModifier;
    public GameObject pickupEffect;
        // Start is called before the first frame update
    void Start()
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);
        instance = this;
        this.enabled = false ;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if(touch.phase==TouchPhase.Moved)
            {
                
                transform.position = new Vector3(
                    transform.position.x,
                    transform.position.y,
                    Mathf.Clamp(transform.position.z + touch.deltaPosition.y * speedModifier, -11.98f, -0.51f));
            }
        }
        
           

    }
}
