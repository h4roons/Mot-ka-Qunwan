
using UnityEngine;

public class obstacletrigg2 : MonoBehaviour
{
    [SerializeField] private GameObject obstacle;
    
    public void OnTriggerEnter()
    {
        
        obstacle.transform.Rotate(0,90,90);
        obstacle.GetComponent<BoxCollider>().enabled = true;
    }
}
