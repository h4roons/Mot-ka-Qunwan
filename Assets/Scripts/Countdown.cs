using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Countdown : MonoBehaviour
{
    public Gmanager gm;
    public int CountdownTime;
    public TextMeshProUGUI CountdownDisplay;

    public void Start()
    {
        StartCoroutine(CountdownToStart());
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
        gm.Begin();
        yield return new WaitForSeconds(1f);
        CountdownDisplay.gameObject.SetActive(false);

    }
}