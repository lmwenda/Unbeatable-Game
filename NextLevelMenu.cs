using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelMenu : MonoBehaviour
{
    public void Restart()
    {
        RestartMenu();
    }

    void RestartMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("SYSTEM: The User has proceeded to the next Level.");
    }
}
