using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Collider_2 : MonoBehaviour
{
    public GameObject player;
     private EVP.VehicleController playerController;
     private int score = 0;
     private bool prevX = false;
     private bool prevZ = false;
     private bool bLeftRight = false;
     private bool bPrevLeftRight = false;
     private bool bRightLeft = false;
     private bool bPrevRightLeft = false;
   

 
    void Start()
    {
        playerController = player.GetComponent<EVP.VehicleController>();
 
    }

    private void Update()
    { 


    }

    void FixedUpdate()
    {
        RaycastHit hit;


        if (Physics.Raycast(player.transform.position, -Vector3.right, out hit, 500f))
        {
             

            if (hit.collider.gameObject.name == "Collider_2")
            {
                float dot = Vector3.Dot(player.transform.right, player.transform.position - hit.point);

                if (dot < 0)

                {
                    // Debug.Log("left of " + hit.collider.gameObject.name);



                }
                else if (dot > 0)
                {


                    if (prevZ == Input.GetKey(KeyCode.Z))
                    {
                        bLeftRight = true;
                        bRightLeft = false;
                    }


                    //Debug.Log("right of " + hit.collider.gameObject.name);

                }
                else
                {

                }
            }


        }

        if (Physics.Raycast(player.transform.position, Vector3.right, out hit, 500f))
        {
            
            if (hit.collider.gameObject.name == "Collider_2")
            {
                float dot = Vector3.Dot(player.transform.right, player.transform.position - hit.point);

                if (dot < 0)
                {
                    if (prevX == Input.GetKey(KeyCode.Q))
                    {
                        bLeftRight = false;
                        bRightLeft = true;

                    }


                }

                else if (dot > 0)
                {
                    // Debug.Log("right of " + hit.collider.gameObject.name);
                }

            }
        }



        if (bPrevLeftRight == true && bLeftRight == false)
        {
            if (Input.GetKey(KeyCode.Z))
            {
                Debug.Log("Positive");
            }
            else
            {
                Debug.Log("negative");
            }
            //Debug.Log("right to left");
        }

        if (bPrevRightLeft == true && bRightLeft == false)
        {

            if (!Input.GetKey(KeyCode.Q))
            {
               Debug.Log("negative");
            }
            else
            {
                Debug.Log("positive");
            }
            // Debug.Log("left to right");
        }
        bPrevLeftRight = bLeftRight;
        bPrevRightLeft = bRightLeft;
        prevZ = Input.GetKey(KeyCode.Z);
        prevX = Input.GetKey(KeyCode.Q);

    }




}

