
using UnityEngine;
using UnityEngine.SceneManagement;

public class credits : MonoBehaviour
{   
   
    public void Quit()
    {
        Debug.Log("Quit!");
        SceneManager.LoadScene(0);
    }
}
