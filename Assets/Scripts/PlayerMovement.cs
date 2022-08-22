
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private Rigidbody rb;
    [SerializeField] private float upforce = 10f;
    [SerializeField] private float downforce;
    [SerializeField] AudioClip BikeEngine;
    AudioSource audioSource;
    private void Start()
    {
        audioSource= GetComponent<AudioSource>();
    }
    

    void FixedUpdate()
    {
       
       
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Stationary)
                {
                    audioSource.PlayOneShot(BikeEngine);
                    rb.AddForce(0, 0, upforce * Time.deltaTime, ForceMode.Force);

                }

            }

            rb.AddForce(0, 0, downforce * Time.deltaTime, ForceMode.Acceleration);
            audioSource.Stop();

            if (rb.position.y < -1f)
            {
                FindObjectOfType<Gmanager>().EndGame();
            }
       
    }


}

