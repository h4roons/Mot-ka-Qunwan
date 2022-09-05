
using UnityEngine;
using TMPro;
public class score : MonoBehaviour
{
    public Transform cube;
    public TextMeshProUGUI scoretext;
    public float x= 0f;
    void FixedUpdate()
    {
        scoretext.SetText(((cube.rotation.x+1)*45f).ToString("0"));
    }
}
