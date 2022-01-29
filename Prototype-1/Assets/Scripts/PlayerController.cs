using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // variables
    public float vehicleSpeed = 10.0f;
    public float vehicleTurnSpeed;
    public float horizontalInput;
    public float forwardInput;

    void Start()
    {
        
    }

    void Update()
    {
        // horizontal & forward/backward input is set from Unity's Input Manager
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // player vehicle forward/backward movement
        transform.Translate(Vector3.forward * Time.deltaTime * 20 * forwardInput);

        // player vehicle horizontal rotational movement
        transform.Rotate(Vector3.up, Time.deltaTime * horizontalInput * vehicleTurnSpeed);
    }
}
