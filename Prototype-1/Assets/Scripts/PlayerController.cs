using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // variables
    public float vehicleSpeed = 10.0f;

    void Start()
    {
        
    }

    void Update()
    {
        // player vehicle forward movement
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }
}
