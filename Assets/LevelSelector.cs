using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public int level;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OpenScene()
    {
        Initiate.Fade("Level "+level, Color.black, 6f);
        //SceneManager.LoadScene("Level " + level);
        Debug.Log("Button Pressed");
    }
}