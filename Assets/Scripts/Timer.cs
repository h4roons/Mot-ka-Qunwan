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
   
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        instance.enabled = false;
        timerSeconds = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f2");
        if (timer <= 0)
        {
            timerSeconds.text = timer.ToString("0");
            timer = 0;
            Invoke("CompleteGame", 3f);
        }
    }
    void CompleteGame()
    {
        Gmanager.instance.CompleteGame();
    }
}
