
using UnityEngine;

public class obstaclesimple : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    

    public void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Player")
        {
            
            rb.isKinematic = false;
            
        }
    }
}
