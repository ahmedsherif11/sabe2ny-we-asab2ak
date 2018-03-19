using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollision : MonoBehaviour
{

    Rigidbody m_Rigidbody;
    EVP.VehicleCameraController cameraController;
    private void Start()
    {
        //Fetch the Rigidbody component from the GameObject
       // m_Rigidbody = GetComponent<Rigidbody>();
        //Ignore the collisions between layer 0 (default) and layer 8 (custom layer you set in Inspector window)
        Physics.IgnoreLayerCollision(8, 9);


    }

    // Update is called once per frame
    void Update()
    {

    }


    //Detect when there is a collision
    void OnCollisionStay(Collision collide)
    { 

    }
}
