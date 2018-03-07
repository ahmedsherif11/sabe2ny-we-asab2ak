using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ccccc : MonoBehaviour {
    public GameObject anyname;
    public GameObject anytime;
    public GameObject anygo0;


    void Start()
    {
        anyname.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().enabled = true;
        anytime.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().enabled = true;
        anygo0.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().enabled = true;


    }

}

