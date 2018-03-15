using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class speedlim : MonoBehaviour
{
    public GameObject player;
    public GameObject AI;
    private EVP.VehicleController playerController;
    public float speedLimit = 20; // KMPH

    void Start()
    {
        playerController = player.GetComponent<EVP.VehicleController>();


    }

    private void Update()
    {

        float forward_projection = Vector3.Dot(player.transform.forward, AI.transform.forward);
        //Debug.Log("projection" + projection.ToString());

        if (forward_projection > 0)
        {


            float dot = Vector3.Dot(AI.transform.right, player.transform.position - AI.transform.position);

 

            float forwardProjected = Vector3.Dot(player.transform.forward, AI.transform.position - player.transform.position);

            float projected_vector = forwardProjected / player.transform.forward.magnitude;

            if (projected_vector < 0.5f && projected_vector > 0) //   meters
            {
                if (dot < 0)
                {
                    Debug.Log("Left of the truck");
                }
                else
                {
                    Debug.Log("Right of the Truck");
                }

            }

            if (playerController != null)
            {

                float speed = Mathf.Abs(playerController.speed);

                if (speed > speedLimit)
                {

                    Debug.Log("Speed Limit Reached");
                }
                // Debug.Log("Speed" + speed.ToString());

            }

        }

 
    }


}

