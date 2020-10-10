using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishedParkour : MonoBehaviour
{

    public GameManager GameManager;

    void OnTriggerEvent()
    {
        Debug.Log("HIT HIT HIT HIT!!!!!!!");
        FindObjectOfType<GameManager>().GameOver();
    }

    void OnCollisionEnter (Collision collisionInfo)
    { 
        if(collisionInfo.collider.tag == "Finish")
        {
            FindObjectOfType<GameManager>().GameOver();
            Debug.Log("SYSTEM: Gamemode Complete.");
        }
    }
}
