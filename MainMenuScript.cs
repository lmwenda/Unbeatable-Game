using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour{
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);       
    }

    public void TutorialGame()
    {
        SceneManager.LoadScene("Tutorial");
        Debug.Log("SYSTEM: Use joined Tutorial mode");
    }

    public void ParkourGame(){
        SceneManager.LoadScene("Parkour1");
        Debug.Log("SYSTEM: User joined Parkour mode.");
    }

    public void QuitGame ()
    {
        Debug.Log("SYSTEM: The User has quit the Game!");
        Application.Quit();
    }
}
