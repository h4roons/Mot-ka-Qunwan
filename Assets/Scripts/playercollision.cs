using System;
using System.Collections;
using UnityEngine;

public class playercollision : MonoBehaviour
{
    public static playercollision instance;
    [SerializeField] private PlayerMovement movement;
    [SerializeField] private Rigidbody rb;
    public Gmanager gm;
    public GameObject AudioManager;
    AudioSource source;




    private void Start()
    {
        instance = this;
    }


    void OnCollisionEnter(UnityEngine.Collision col)
    {
        
        if (col.gameObject.tag == "Obstacle")
        {
            audioManager.instance.StopSound("Background");
            bool  played = false;
            
            if (!played)
            {
                audioManager.instance.PlaySound("Collision");
                played = true;
            }




                CameraShake.instance.enabled = true;
                CameraShake.instance.ShakeCamera(0.5f, 0.1f);
            
            
                
            
            
                
            
            

            rb.useGravity = true;
            rb.constraints = RigidbodyConstraints.None;
            movement.enabled = false;

            FindObjectOfType<Gmanager>().EndGame();
           
            Debug.Log("Collided");
            


        }

       
        

        if (col.collider.tag == "Obstacle")
        {
            Time.timeScale = 0.5f;
            
           
        }
        else
        {
            //Time.timeScale = 1;
        }
        

    }
    
    
}
