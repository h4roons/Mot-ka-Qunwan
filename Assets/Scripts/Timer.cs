using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Timer : MonoBehaviour
{
    
    public static Timer instance;
    public string LevelToLoad;
    public float timer = 12f;
    private Text timerSeconds;
    public Slider timerslider;
    //public ParticleSystem Confetti;

    private bool stoptimer;
    void Start()
    {

        instance = this;
        instance.enabled = false;
        
        timerSeconds = GetComponent<Text>();
        timerslider.maxValue = timer;
        timerslider.value = timer;
        
        //Confetti.Stop();



    }

    void FixedUpdate()
    {
        timer -= Time.deltaTime;
        

        timerSeconds.text = timer.ToString("f2");
        if (timer <= 0)
        {
            timerSeconds.text = timer.ToString("0");
            stoptimer = true;
            timer = 0;
            //ParticleEffect.SetActive(true);
            // Confetti.Play();
            CompleteGame();
        }

        if(stoptimer == false)
        {
            timerslider.value = timer;

        }
    }
    void CompleteGame()
    {
        
        Gmanager.instance.CompleteGame();
    }
}
