using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public GameObject loadbar;
    public static LevelSelector instance;
    public int level;
    public Slider slider;
    public Text ProgressText;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        

    }


    public void OpenScene()
    {
        //Initiate.Fade("Level "+level, Color.black, 0f);
        //SceneManager.LoadSceneAsync("Level " + level);
        //Debug.Log("Button Pressed");
        StartCoroutine(LoadASynchronously());

    }
    IEnumerator LoadASynchronously()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("Level " + level);
        loadbar.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            slider.value = progress;
            ProgressText.text = progress * 100f + "%";
            yield return null;
       }
    }
}
