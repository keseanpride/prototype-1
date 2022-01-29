using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // variables
    public GameObject playerVehicle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // main camera's transform is set relative to player vehicle's transform
        transform.position = playerVehicle.transform.position;
    }
}
