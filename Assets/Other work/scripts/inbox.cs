using UnityEngine;
using System.Collections;
using UnityStandardAssets.Vehicles.Car;

public class inbox : MonoBehaviour
{
    private bool inVehicle = true;
    CarUserControl vehicleScript;
    public GameObject guiObj;
    public GameObject player;
    public int fuel=10 ;
    private EVP.VehicleController controler;
    public GameObject box;
    public GameObject box2;


    void Start()
    {
        vehicleScript = GetComponent<CarUserControl>();
        guiObj.SetActive(false);
        box.SetActive(true);
        box2.SetActive(false);
        controler = player.GetComponent<EVP.VehicleController>();
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            guiObj.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                guiObj.SetActive(false);

                // set speed = 0
                controler.enabled = false;

                for (int i = fuel ; i <= 50; i++)
                { 
                fuel = fuel + 1;
                wait();
                }
                controler.enabled = true;
                box.SetActive(false);
                box2.SetActive(true);

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
    IEnumerator wait()
    {
        yield return new WaitForSeconds(1);
    }


}