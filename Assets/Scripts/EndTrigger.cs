using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    
    public Gmanager gm;
    


    public void OnTriggerEnter()
    {
        stadiumMovement.instance.enabled = false;
        gm.CompleteGame();
        
    }
}
