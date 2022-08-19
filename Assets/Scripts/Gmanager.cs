
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gmanager : MonoBehaviour
{
    bool gameEnded = false; 
    public float restartdelay = 2f;
    public GameObject completelevelUI;
    public void CompleteGame()
    {
        Debug.Log("WON");
        completelevelUI.SetActive(true);
        
    }
    public void EndGame()
    {
        if(gameEnded == false)
        {
           gameEnded = true;
           Debug.Log("Game Over");
           Invoke("Restart", restartdelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
