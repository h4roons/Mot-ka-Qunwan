
using UnityEngine;

public class playercollision : MonoBehaviour
{
    public PlayerMovement movement;
    public Gmanager gm;
    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<Gmanager>().EndGame();
        }

        if (collisionInfo.collider.tag == "Obstacle")
        {
            Time.timeScale = 0.5f;
        } 
        else
        {
            Time.timeScale = 1;
        }

    }
}
