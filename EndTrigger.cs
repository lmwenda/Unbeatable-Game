using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    // Game Mananger Public Variable
    public GameManager gameManager;

    // Trigger Event Funtion
    void OnTriggerEnter ()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}