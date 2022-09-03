
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gmanager : MonoBehaviour
{
    bool gameEnded = false; 
    public float restartdelay = 2f;
    public GameObject completelevelUI;
    public GameObject player;
    public GameObject stadium;
    
    public void Begin()
    {
        player.GetComponent<Drag>().enabled = true;
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
            Debug.Log("Game Over");
           Invoke("Restart", 3.5f);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
}
