
using UnityEngine;

public class obstacletrigg2 : MonoBehaviour
{
    [SerializeField] private GameObject obstacle;
    [SerializeField] private Rigidbody rb;
    public void OnTriggerEnter()
    {
        rb.constraints &= ~RigidbodyConstraints.FreezeRotationZ;
        obstacle.transform.Rotate(0, 0, 90);
        obstacle.GetComponent<BoxCollider>().enabled = true;
    }
}
