using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // variables
    public float vehicleSpeed = 10.0f;
    public float vehicleTurnSpeed;
    public float horizontalInput;

    void Start()
    {
        
    }

    void Update()
    {
        // horizontal input is set from Unity's Input Manager
        horizontalInput = Input.GetAxis("Horizontal");

        // player vehicle forward movement
        transform.Translate(Vector3.forward * Time.deltaTime * 20);

        // player vehicle horizontal movement
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput);
    }
}
