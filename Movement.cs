using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour{

    public Rigidbody rb;
    public float forwardForce = 2000f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("SYSTEM: Starting Game...");
        rb.useGravity = true;
        FixedUpdate();
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        rb.AddForce(forwardForce * Time.deltaTime, 0, 0); // This Physics Statement will make the Player go forward because of the forwardForce Statement above

        if(Input.GetKey("d"))
        {
            // This Conditional Statement will only Execute if the Player presses D
           rb.AddForce(0, 0, -1000 * Time.deltaTime); // to go Right
        }

        if(Input.GetKey("a")){
           // This Conditional Statement will only Execute if the Player presses A
           rb.AddForce(0, 0, 500 * Time.deltaTime); // to go left
        }
        
        // Check if Play goes Off the Map
        if (rb.position.y < -1f)
        {
            SceneManager.LoadScene("Start_Menu");
        }
    }
}
