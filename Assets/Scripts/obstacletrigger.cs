
using UnityEngine;

public class obstacletrigger : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    public float force = 650f;

    private void OnTriggerEnter()
    {
        rb.AddForce(0, 0, force * Time.deltaTime,ForceMode.Impulse);
        
    }

    


}
