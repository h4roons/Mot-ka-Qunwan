using DG.Tweening;
using UnityEngine;

public class DragMovement : MonoBehaviour
{
    private Touch touch;
    [SerializeField]private float speedModifier;

    [SerializeField] private Vector2 clampValues;

    [SerializeField] private float maxHandleRotation;

    [SerializeField] private Transform handleBar;

    private Vector3 moveVector;
    // Start is called before the first frame update
   

    // Update is called once per frame
  private  void Update()
  {
       //if (Input.touchCount > 0)
        // {
        //    touch = Input.GetTouch(0);
        //    if(touch.phase==TouchPhase.Moved)
         //   {
         //        transform.position = new Vector3(
        //            transform.position.x,
       //              transform.position.y,
       //              Mathf.Clamp(transform.position.z + touch.deltaPosition.y * speedModifier, clampValues.x, clampValues.y));
        //     }
       //  }

        if (!Input.GetMouseButton(0)) return;
        var xMove = Input.GetAxis("Mouse X");
      
        //transformation
        moveVector.x += xMove * speedModifier * Time.deltaTime;
        var angleToRotate = maxHandleRotation * xMove;
        //rotation
        handleBar.transform.DOLocalRotate(new Vector3(0, 0,angleToRotate), .15f);
        
      
        
        transform.position = moveVector;



  }
}
