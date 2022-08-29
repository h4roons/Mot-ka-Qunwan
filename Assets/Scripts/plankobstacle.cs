
using UnityEngine;

public class plankobstacle : MonoBehaviour
{
    [SerializeField] private Rigidbody Rb;
    public void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Player")
        {
            stadiumMovement.instance.enabled = false;
            Rb.useGravity = true;
            Rb.constraints = RigidbodyConstraints.None;
        }
    }
}
