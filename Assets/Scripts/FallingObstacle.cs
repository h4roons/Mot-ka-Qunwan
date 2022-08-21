
using UnityEngine;

public class FallingObstacle : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    public void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Player")
        {
            rb.useGravity = true;
        }
    }

}
