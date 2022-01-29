using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // variables
    public GameObject playerVehicle;
    private Vector3 cameraOffset = new Vector3(0, 5, -8);

    void Start()
    {
        
    }

    void LateUpdate()
    {
        // main camera's transform is set relative to player vehicle's transform + its camera offset
        transform.position = playerVehicle.transform.position + cameraOffset;
    }
}
