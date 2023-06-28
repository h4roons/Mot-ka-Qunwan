using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Countdown : MonoBehaviour
{
    //public GameObject timer;
    public Gmanager gm;
    public int CountdownTime;
    public TextMeshProUGUI CountdownDisplay;

    public void Start()
    {
        
        StartCoroutine(CountdownToStart());
        //Timer.instance.enabled = false;
        //timer.SetActive(false) ;
    }

    IEnumerator CountdownToStart()
    {
        while(CountdownTime > 0)
        {
            CountdownDisplay.text = CountdownTime.ToString();

            yield return new WaitForSeconds(1f);
            CountdownTime--;
        }

        CountdownDisplay.text = "GO!";
        bool played = false;
        if (!played)
        {
            audioManager.instance.PlaySound("Game Start");
            played = true;
        }
        gm.Begin();
        
        yield return new WaitForSeconds(1f);
        CountdownDisplay.gameObject.SetActive(false);

    }
}
