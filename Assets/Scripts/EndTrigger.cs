using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endTrigger : MonoBehaviour
{
    public Gmanager gm;

    public void OnTriggerEnter()
    {
        gm.CompleteGame();
    }
}
