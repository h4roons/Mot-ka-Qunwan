
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public Gmanager gameManager;
    void OnTriggerEnter()
    {
        gameManager.CompleteGame();
    }
}
