using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class score : MonoBehaviour
{
    public Transform cube;
    public TextMeshProUGUI scoretext;
    public float x= 0f;

    // Update is called once per frame
    void Update()
    {
        scoretext.SetText((cube.rotation.x+1).ToString("0"));
    }
}
