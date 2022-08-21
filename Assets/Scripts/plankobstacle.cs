
using UnityEngine;

public class plankobstacle : MonoBehaviour
{
    Rigidbody Rb;

    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

   
    public void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Player")
        {
            Rb.useGravity = true;
            Rb.constraints = RigidbodyConstraints.None;
        }
    }
}
