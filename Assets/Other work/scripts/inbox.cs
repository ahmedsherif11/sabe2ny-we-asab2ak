using UnityEngine;
using System.Collections;
using UnityStandardAssets.Vehicles.Car;

public class inbox : MonoBehaviour
{
    private bool inVehicle = true;
    CarUserControl vehicleScript;
    public GameObject guiObj;
    public GameObject player;
    public int fuel = 10;
    private EVP.RigidbodyPause controler;
    private EVP.VehicleAudio audiio;
    public GameObject box;
    public GameObject box2;
    private IEnumerator coroutine;
    private bool bTriggered = false;

    void Start()
    {
        vehicleScript = GetComponent<CarUserControl>();
        guiObj.SetActive(false);
        box.SetActive(true);
        box2.SetActive(false);
        controler = player.GetComponent<EVP.RigidbodyPause>();
        audiio = player.GetComponent<EVP.VehicleAudio>();
        coroutine = WaitAndPrint(0.7f);

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
                controler.enabled = true;
                audiio.enabled = false;
                 
                controler.enabled = false;
                audiio.enabled = true;

                box.SetActive(false);
                box2.SetActive(true);

            }


        }
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            StartCoroutine(coroutine);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            guiObj.SetActive(false);
        }
    }
    private IEnumerator WaitAndPrint(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            fuel++;
            print("fuel" + fuel);
            if ( fuel >=100)
            {
                StopCoroutine(coroutine);
            }
        }
        
    }



}