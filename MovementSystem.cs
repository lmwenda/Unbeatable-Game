using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementSystem : MonoBehaviour
{
    public bool jumpkeypressed;
    private bool isGrounded;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
           jumpkeypressed = true;
        }

        if(Input.GetKey("d"))
        {
            GetComponent<Rigidbody>().AddForce(5, 0, 0);
        }
        
        if(Input.GetKey("a"))
        {
            GetComponent<Rigidbody>().AddForce(-5, 0, 0);
        }

        // Check if Play goes Off the Map
        if (GetComponent<Rigidbody>().position.y < -4f)
        {
            SceneManager.LoadScene("Start_Menu");
        }

        if(GetComponent<Rigidbody>().position.x > 17f)
        {
            Debug.Log("SYSTEM: User has Completed Parkour Level 1.");
            SceneManager.LoadScene("Start_Menu");
        }
    }

    private void FixedUpdate()
    {
        if(isGrounded != true){
            return;
        }

        if(jumpkeypressed){
           GetComponent<Rigidbody>().AddForce(Vector3.up * 4, ForceMode.VelocityChange);
           jumpkeypressed = false;
        }
    }

    private void OnCollisionEnter(Collision collision){
        isGrounded = true;
    }

    private void OnCollisionExit(Collision collision){
        isGrounded = false;
    }
}