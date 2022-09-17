using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CigarettePowerup : MonoBehaviour
{
    public Transform Cigarette;
    public float speed;
    public float Multiplier = 6f;
    
    public GameObject pickupEffect;

    private void Update()
    {
        Cigarette.transform.Rotate(0, 0, 10 * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            audioManager.instance.PlaySound("Cigarette");
            StartCoroutine( Pickup(other) );
           
        }
        
    }

    IEnumerator Pickup(Collider player)
    {
        
        
        Instantiate(pickupEffect, transform.position, transform.rotation);


        Time.timeScale = 1.5f;
        //Player.transform.parent.localScale*= Multiplier;
        //player.GetComponent<Collider>().enabled=false;
        //GetComponent<MeshRenderer>().enabled = false;
        //GetComponent<Collider>().enabled = false;
        //stadiumMovement.instance._speed /= Multiplier ;

        yield return new WaitForSecondsRealtime(3f);
        //player.GetComponent<Collider>().enabled = true;
        //stadiumMovement.instance._speed *= Multiplier;
        Time.timeScale = 1f; 
        Destroy(gameObject);
        
    }
    
}
