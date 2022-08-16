using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoretext;
    public float x= -5.14f;

    // Update is called once per frame
    void Update()
    {
        scoretext.SetText((player.position.z-x).ToString("0"));
    }
}
