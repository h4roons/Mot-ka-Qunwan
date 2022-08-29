
using UnityEngine;

public class stadiumMovement : MonoBehaviour
{
    public static stadiumMovement instance;  
    [SerializeField] private float _speed;
    [SerializeField] private Transform _cubeAxis;

    private void Start()
    {
        instance = this;
        audioManager.instance.PlaySound("Background");
        
       
    }
    void Update()
    {
        //transform.Rotate(0f,10 * _speed *Time.deltaTime,0f,Space.Self);
        
        
            _cubeAxis.Rotate(0f, 0f, 10 * _speed * Time.deltaTime, Space.Self);
                    
        
    }
}
