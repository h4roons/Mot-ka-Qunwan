
using UnityEngine;

public class stadiumMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.Rotate(0f,10 * _speed *Time.deltaTime,0f,Space.Self);
    }
}
