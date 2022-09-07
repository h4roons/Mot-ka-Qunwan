
using UnityEngine;

public class plankobstacle : MonoBehaviour
{
    [SerializeField] private Rigidbody Rb;
    public GameObject pickupEffect;
    public void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Player")
        {
            Instantiate(pickupEffect, transform.position, transform.rotation);
            stadiumMovement.instance.enabled = false;
            Rb.useGravity = true;
            Rb.constraints = RigidbodyConstraints.None;
        }
    }
}
