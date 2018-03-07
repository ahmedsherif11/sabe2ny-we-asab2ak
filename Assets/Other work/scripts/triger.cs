using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triger : MonoBehaviour
{


    public GameObject laptrig;
    public GameObject Hlaptrig;

    void OnTriggerEnter()
    {
        laptrig.SetActive(true);
        Hlaptrig.SetActive(false);
    }
}