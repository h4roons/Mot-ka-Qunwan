
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private Rigidbody rb;
    [SerializeField] private float force = 10f;
    // Update is called once per frame
    //but we use fixed update method to even the frames per sec
    //on faster devices
    void FixedUpdate()
    {

      
       if (Input.GetKey(KeyCode.Mouse0))
       {
          rb.AddForce(0,force*Time.deltaTime, 0, ForceMode.VelocityChange);
            Debug.Log("held");
       }
       if (!Input.GetKey(KeyCode.Mouse0))
       {
          rb.AddForce(0, -force*Time.deltaTime, 0, ForceMode.VelocityChange);
            Debug.Log("Not Held");
       }
      
   
    }

}
