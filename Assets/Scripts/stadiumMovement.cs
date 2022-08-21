
using UnityEngine;

public class stadiumMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _cubeAxis;
 
    void Update()
    {
        //transform.Rotate(0f,10 * _speed *Time.deltaTime,0f,Space.Self);
        
        
            _cubeAxis.Rotate(0f, 0f, 10 * _speed * Time.deltaTime, Space.Self);
        
        
    }
}
