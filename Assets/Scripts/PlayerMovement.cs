
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private Rigidbody rb;
    [SerializeField] private float upforce = 10f;
    [SerializeField] private float downforce;
    // Update is called once per frame
    //but we use fixed update method to even the frames per sec
    //on faster devices
    void FixedUpdate()
    {

      
       if (Input.GetKey(KeyCode.Mouse0))
       {
          rb.AddForce(0,0, upforce * Time.deltaTime, ForceMode.Force);
            Debug.Log("held");
       }
       if (!Input.GetKey(KeyCode.Mouse0))
       {
          rb.AddForce(0,0 , downforce * Time.deltaTime, ForceMode.Acceleration);
            Debug.Log("Not Held");
       }
      
   
    }

}
