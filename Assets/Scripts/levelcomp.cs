
using UnityEngine;

using UnityEngine.SceneManagement;
public class levelcomp : MonoBehaviour
{
    public void Loadnextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

