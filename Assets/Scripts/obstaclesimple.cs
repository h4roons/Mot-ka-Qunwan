
using UnityEngine;

public class obstaclesimple : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    public GameObject CollisionEffect;
    

    public void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Player")
        {
            Instantiate(CollisionEffect, transform.position, transform.rotation);
            rb.isKinematic = false;
            FindObjectOfType<Gmanager>().EndGame();

        }
    }
}
