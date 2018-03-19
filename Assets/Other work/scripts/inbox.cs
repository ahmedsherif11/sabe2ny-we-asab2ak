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
    private EVP.VehicleController controler;
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
        controler = player.GetComponent<EVP.VehicleController>();
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
                controler.enabled = false;
                audiio.enabled = false;
                bTriggered = true;



            }


        }
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.E) && bTriggered)
        {
            StartCoroutine(coroutine);
            bTriggered = false;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            guiObj.SetActive(false);
            bTriggered = false;
        }
    }
    private IEnumerator WaitAndPrint(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            fuel++;
            print("fuel" + fuel);
            controler.GetComponent<Rigidbody>().velocity = Vector3.zero;
            controler.GetComponent<Rigidbody>().Sleep();
            if ( fuel >=100)
            {

                controler.enabled = true;
                audiio.enabled = true;
                box.SetActive(false);
                box2.SetActive(true);
                StopCoroutine(coroutine);
            }
        }
        
    }



}