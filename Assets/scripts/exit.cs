using UnityEngine;
using System.Collections;
using UnityStandardAssets.Vehicles.Car;
using System.Collections.Generic;
using UnityEngine.UI;

public class exit : MonoBehaviour
{
    private bool inVehicle = false;
     CarUserControl vehicleScript;
    public GameObject guiObj;
    GameObject player;
    public GameObject carcam;
    public GameObject percam;



    void Start()
    {
        vehicleScript = GetComponent<CarUserControl>();
        player = GameObject.FindWithTag("Player");
        guiObj.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && inVehicle == false)
        {
            guiObj.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                carcam.SetActive(true);
                percam.SetActive(false);
                guiObj.SetActive(false);
                player.transform.parent = gameObject.transform;
                vehicleScript.enabled = true;
                player.SetActive(false);
                inVehicle = true;

            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            guiObj.SetActive(false);
        }
    }
    void Update()
    {
        if (inVehicle == true && Input.GetKey(KeyCode.F))
        {
            carcam.SetActive(false);
            percam.SetActive(true);
            vehicleScript.enabled = false;
            player.SetActive(true);
            player.transform.parent = null;
            inVehicle = false;

        }
    }
}