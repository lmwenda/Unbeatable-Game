using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{

    // Player Movement and Game Manager Variable
    public NewBehaviourScript movement;

    // Making the Won Game Text disapper when you start the game
    
    // Collision Function
    void OnCollisionEnter (Collision collisionInfo)
    { 
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
            Debug.Log("SYSTEM: Game Over!");
        }

        if(collisionInfo.collider.tag == "Finisher"){
            movement.enabled = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("SYSTEM: The User has won the Game!");
        }
    }
  
    
    // Start is called before the first frame update
    void Start()
    {
       // SampleScene.Canvas.won.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
