using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private variables
    private float speed = 25.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float verticalInput;
    public Camera camera1;
    public Camera camera2;
    public KeyCode switchkey;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get player input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //Move player forward 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
       //Turn player
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        if (Input.GetKeyDown(switchkey)) 
        {
            camera1.enabled = !camera1.enabled;
            camera2.enabled = !camera2.enabled;
        }

    }
}
