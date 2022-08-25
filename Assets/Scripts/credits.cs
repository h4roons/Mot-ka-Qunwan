
using UnityEngine;

public class credits : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("Quit!");
        Application.LoadLevel(0);
    }
}
