
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private Rigidbody rb;
    [SerializeField] private float upforce = 10f;
    [SerializeField] private float downforce;


    void Update()
    {


        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Stationary)
            {
                rb.AddForce(0, 0, upforce * Time.deltaTime, ForceMode.Force);

            }

        }
    }
    void FixedUpdate()
    {

        rb.AddForce(0, 0, downforce * Time.deltaTime, ForceMode.Acceleration);

        if (rb.position.y < -1f)
        {
            FindObjectOfType<Gmanager>().EndGame();
        }
    }


}

