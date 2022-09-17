using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    
    


    public void OnTriggerEnter()
    {
        
        bool played = false;
        if (!played)
        {
            
            audioManager.instance.PlaySound("Crazy");
            played = true;
        }
        
    }
}
