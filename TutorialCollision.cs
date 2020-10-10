using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialCollision : MonoBehaviour
{

    // Player Movement and Game Manager Variable
    public Movement movement;

    // Collision Function
    void OnCollisionEnter (Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            SceneManager.LoadScene("Start_Menu");
            Debug.Log("SYSTEM: Game Over!");
        }

        if(collisionInfo.collider.tag == "Finish"){
            movement.enabled = false;
            SceneManager.LoadScene("SampleScene");
            Debug.Log("SYSTEM: The User has won the Game!");
        }
    }
}