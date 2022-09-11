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
    public Transform bike_Child;
    public Vector3 idle=Vector3.zero;
    public Vector3 tilt;
    public float rotation_speed;
    public Vector3 targetRotation;
    float currentPOS = 0f;
    float previousPOS= -6.12f;

    // Start is called before the first frame update
    void Start()
    {
        
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


                currentPOS = transform.position.z;
                if (currentPOS < previousPOS)
                {
                    bike_Child.transform.localRotation = Quaternion.Slerp(bike_Child.transform.localRotation, Quaternion.Euler(targetRotation), rotation_speed * Time.deltaTime);
                }
                if (currentPOS > previousPOS)
                {
                    bike_Child.transform.localRotation = Quaternion.Slerp(bike_Child.transform.localRotation, Quaternion.Euler(-targetRotation), rotation_speed * Time.deltaTime);
                }
                if (currentPOS == previousPOS)
                {
                    bike_Child.transform.localRotation = Quaternion.Slerp(bike_Child.transform.localRotation, Quaternion.Euler(idle), rotation_speed * Time.deltaTime);
                }
                previousPOS = currentPOS;
                
                //if (transform.position.z < -6.12f)
                //{
                //    bike_Child.transform.localRotation = Quaternion.Slerp(bike_Child.transform.localRotation, Quaternion.Euler(targetRotation), rotation_speed * Time.deltaTime);
                //}
                //else if (transform.position.z > -6.12f)
                //{
                //    bike_Child.transform.localRotation = Quaternion.Slerp(bike_Child.transform.localRotation, Quaternion.Euler(-targetRotation), rotation_speed * Time.deltaTime);
                //}
            }
            if (touch.phase == TouchPhase.Ended)
            {
                bike_Child.transform.localRotation = Quaternion.Slerp(bike_Child.transform.localRotation, Quaternion.Euler(idle), rotation_speed * Time.deltaTime);
            }
        }
        
           

    }
}
