
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void startgame()
    {
        Debug.Log("start");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
