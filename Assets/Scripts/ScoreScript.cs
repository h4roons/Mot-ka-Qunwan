using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreScript : MonoBehaviour
{
    
    
    public GameObject ParticleEffect;
   
    void Start()
    {

        
        
        
    }
    

    private void OnTriggerEnter(Collider other)
    {
        
         
        if (other.tag == "Player")
        {
            
                Instantiate(ParticleEffect, transform.position, transform.rotation);
                
                
                Destroy(gameObject);
                

            
            
            


        }
    }
   
}
