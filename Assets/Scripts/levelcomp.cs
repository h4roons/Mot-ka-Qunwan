
using UnityEngine;
using UnityEngine.UI;
using TMPro;

using UnityEngine.SceneManagement;
public class levelcomp : MonoBehaviour
{
    
    public void Loadnextlevel()
    {
       
        SceneManager.LoadScene(2);
    }
}

