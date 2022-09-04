using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LassiPowerup : MonoBehaviour
{
    public float Multiplier = 6f;
    
    public GameObject pickupEffect;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

           StartCoroutine( Pickup(other) );
        }
        
    }

    IEnumerator Pickup(Collider player)
    {
        
        
        Instantiate(pickupEffect, transform.position, transform.rotation);
        
            
        
        //Player.transform.parent.localScale*= Multiplier;
        //player.GetComponent<Collider>().enabled=false;
        //GetComponent<MeshRenderer>().enabled = false;
        //GetComponent<Collider>().enabled = false;
        stadiumMovement.instance._speed /= Multiplier ;
        yield return new WaitForSeconds(4f);
        //player.GetComponent<Collider>().enabled = true;
        stadiumMovement.instance._speed *= Multiplier;
        Destroy(gameObject);
        
    }
}
