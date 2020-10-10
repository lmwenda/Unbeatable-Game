using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Creating a Game Ended Bool Value
    bool gamehasEnded = false;
    public void GameOver ()
    {
        if (gamehasEnded == false)
        {
            gamehasEnded = true;
            Debug.Log("SYSTEM: Game Over!");
            // Restart Game
            RestartGame();
        }
    }

    void RestartGame ()
    {
        SceneManager.LoadScene("Start_Menu");
    }
}
