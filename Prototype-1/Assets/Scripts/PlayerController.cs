using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // variables
    private float vehicleSpeed = 15.0f;
    private float vehicleTurnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    void Start()
    {
        
    }

    void Update()
    {
        // horizontal & forward/backward input is set from Unity's Input Manager
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // player vehicle forward/backward movement
        transform.Translate(Vector3.forward * Time.deltaTime * forwardInput * vehicleSpeed);

        // player vehicle horizontal rotational movement
        transform.Rotate(Vector3.up, Time.deltaTime * horizontalInput * vehicleTurnSpeed);
    }
}
