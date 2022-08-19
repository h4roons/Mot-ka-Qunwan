
using UnityEngine;

public class playercollision : MonoBehaviour
{
    [SerializeField] private PlayerMovement movement;
    [SerializeField] private Rigidbody rb;
    public Gmanager gm;
   
    void OnCollisionEnter(UnityEngine.Collision col)
    {
        if (col.collider.tag == "Obstacle")
        {
            rb.useGravity = true;
            rb.constraints = RigidbodyConstraints.None;
            movement.enabled = false;
            FindObjectOfType<Gmanager>().EndGame();

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
