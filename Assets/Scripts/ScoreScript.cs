using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI text;
    private int ScoreNum;
    public GameObject ParticleEffect;
   
    void Start()
    {
        ScoreNum = 0;
        text.text = "Score : " + ScoreNum; 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Score")
        {
            Instantiate(ParticleEffect, transform.position, transform.rotation);
            ScoreNum++;
            Destroy(other.gameObject);
            text.text = "Score : " + ScoreNum;
        }
    }
}
