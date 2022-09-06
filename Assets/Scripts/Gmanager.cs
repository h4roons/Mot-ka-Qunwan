
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gmanager : MonoBehaviour
{
    public GameObject timer;
    public static Gmanager instance;
    bool gameEnded = false; 
    public float restartdelay = 2f;
    public GameObject completelevelUI;
    public GameObject player;
    public GameObject stadium;

    private void Start()
    {
        instance = this;

    }
    public void Begin()
    {
        timer.SetActive(true);
        Timer.instance.enabled = true;   
        Drag.instance.enabled = true;
        player.GetComponent<PlayerMovement>().enabled = true;
        stadium.GetComponent<stadiumMovement>().enabled = true;
    }

    public void CompleteGame()
    {
        
        completelevelUI.SetActive(true);
        
    }
    public void EndGame()
    {
        if(gameEnded == false)
        {
            
            gameEnded = true;
            stadiumMovement.instance.enabled = false;
            Drag.instance.enabled = false;
            Timer.instance.enabled = false;
            SceneManager.LoadScene(3);
            Debug.Log("Game Over");
           //Invoke("Restart", 3.5f);
        }
    }

    void Restart()
    {
        
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Timer.instance.enabled = false;
        timer.SetActive(false);

    }
}
