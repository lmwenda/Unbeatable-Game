using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMenu : MonoBehaviour
{ 
    public void Restart()
    {
        EnterRestartMenu();
    }

    void EnterRestartMenu()
    {
        SceneManager.LoadScene("Sample_Scene");
        Debug.Log("SYSTEM: Restarted Game.");
    }
}
