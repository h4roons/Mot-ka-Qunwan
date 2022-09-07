
using UnityEngine;

public class FallingObstacle : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    public GameObject pickupEffect;

    public void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Player")
        {
            Instantiate(pickupEffect, transform.position, transform.rotation);
            rb.useGravity = true;
            FindObjectOfType<Gmanager>().EndGame();
        }
    }

}
