using System;
using System.Collections;
using UnityEngine;

public class playercollision : MonoBehaviour
{
    [SerializeField] private PlayerMovement movement;
    [SerializeField] private Rigidbody rb;
    public Gmanager gm;
    public GameObject AudioManager;
    AudioSource source;





    void OnCollisionEnter(UnityEngine.Collision col)
    {
        
        if (col.gameObject.tag == "Obstacle")
        {
            audioManager.instance.StopSound("Background");
            audioManager.instance.PlaySound("Collision");
            
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
            Time.timeScale = 1;
        }

    }
    
    
}
