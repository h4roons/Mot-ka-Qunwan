using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    public static Drag instance;
    private Touch touch;
    [SerializeField]private float speedModifier;
    public GameObject pickupEffect;
   // public Transform gameObj;
    //public Transform handlebar;
   
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
            
            if (touch.phase == TouchPhase.Moved)
            {
                //gameObj.transform.eulerAngles = new Vector3(
            //gameObj.transform.eulerAngles.x,
           // gameObj.transform.eulerAngles.y + 180,
          // gameObj.transform.eulerAngles.z);
                                           

                // handlebar.transform.Rotate(new Vector3(0,Mathf.Clamp(transform.rotation.y+touch.deltaPosition.y*speedModifier,-67.3f,-13.3f),0));
                transform.position = new Vector3(
                    transform.position.x,
                    transform.position.y,
                    Mathf.Clamp(transform.position.z + touch.deltaPosition.y * speedModifier, -11.17f, -0.51f));
            }
        }
        
           

    }
}
