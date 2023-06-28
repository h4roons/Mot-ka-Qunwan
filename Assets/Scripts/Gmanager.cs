
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gmanager : MonoBehaviour
{
    public GameObject timer;
    public static Gmanager instance;
    bool gameEnded = false; 
    public float restartdelay = 2f;
    public GameObject completelevelUI;
    public GameObject stadium;
    public GameObject Bike;

    private void Start()
    {
        Bike = Instantiate(Resources.Load("Bikeeee") as GameObject);
        instance = this;
       ;
        Resources.Load("Bikeeee");

    }
    public void Begin()
    {
      
        PlayerPrefs.SetInt("Level", SceneManager.GetActiveScene().buildIndex);
        timer.SetActive(true);
        Timer.instance.enabled = false;   
        Drag.instance.enabled = true;
        //player.GetComponent<PlayerMovement>().enabled = true;
        stadium.GetComponent<stadiumMovement>().enabled = true;
    }

    public void CompleteGame()
    {

        SceneManager.LoadScene(2); 
        
    }
    public void EndGame()
    {
        if(gameEnded == false)
        {
            
            gameEnded = true;
            stadiumMovement.instance.enabled = false;
           // Drag.instance.enabled = false;
         //   Timer.instance.enabled = false;
            Invoke("Restart", 2f);
            Debug.Log("Game Over");
           
        }
    }

    void Restart()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene(2);
        Timer.instance.enabled = false;
        timer.SetActive(false);

    }
}
