using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public static CameraShake instance;
    public Transform CameraTransform;
    private Vector3 OriginalCameraPosition;
    public float shakeDuration;
    public float shakeAmount;
    private bool canShake=false;
    


    public void ShakeCamera(float _shakeDuration, float _shakeAmount)
    {
       
            shakeDuration = _shakeDuration;
            shakeAmount = _shakeAmount;
            canShake = true;
        

    }
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        OriginalCameraPosition = CameraTransform.localPosition;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        

            if (shakeDuration > 0)
            {


                CameraTransform.localPosition = OriginalCameraPosition + Random.insideUnitSphere * shakeAmount;
                shakeDuration -= Time.deltaTime;


            }
            
        
        else
        {
            shakeDuration = 0f;
            CameraTransform.localPosition = OriginalCameraPosition;
            
        }
    }
}
