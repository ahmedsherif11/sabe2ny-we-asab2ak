using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counter : MonoBehaviour {

    private int count;
    public GameObject counnt;
    private string view;
    public GameObject coins;
    public GameObject coins1;
    public GameObject coins2;
    public GameObject coins3;
    public GameObject coins4;
    public GameObject coins5;
    public GameObject coins6;
    public GameObject coins7;
    public GameObject coins8;
    public GameObject coins9;
    public GameObject coins0;
    public GameObject coins11;
    public GameObject coins12;
    public GameObject coins13;
    public GameObject coins14;
    public GameObject coins15;
    public GameObject coins16;
    public GameObject coins17;
    public GameObject coins18;
    public GameObject coins19;
    public GameObject coins10;
    public GameObject coins22;
    public GameObject coins23;
    public GameObject coins21;
    public GameObject coins24;
    public GameObject coins25;
    public GameObject coins26;
    public GameObject coins27;
    public GameObject coins28;
    public GameObject coins29;
    public GameObject coins20;


    private int kam; 

    private void Start()
    {
        count = 0;
    }



    void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("pickup"))
        {

            other.gameObject.SetActive (false);
    
            count = count + 10;
            kam = kam + 1;
            view = count.ToString("F0");
            counnt.GetComponent<Text>().text =view;

        }
        if (kam >= 13)
        {
            coins.gameObject.SetActive(true);
            coins0.gameObject.SetActive(true);
            coins1.gameObject.SetActive(true);
            coins2.gameObject.SetActive(true);
            coins3.gameObject.SetActive(true);
            coins4.gameObject.SetActive(true);
            coins5.gameObject.SetActive(true);
            coins6.gameObject.SetActive(true);
            coins7.gameObject.SetActive(true);
            coins8.gameObject.SetActive(true);
            coins9.gameObject.SetActive(true);
            coins10.gameObject.SetActive(true);
            coins11.gameObject.SetActive(true);
            coins12.gameObject.SetActive(true);
            coins13.gameObject.SetActive(true);
            coins14.gameObject.SetActive(true);
            coins15.gameObject.SetActive(true);
            coins16.gameObject.SetActive(true);
            coins17.gameObject.SetActive(true);
            coins18.gameObject.SetActive(true);
            coins19.gameObject.SetActive(true);
            coins20.gameObject.SetActive(true);
            coins21.gameObject.SetActive(true);
            coins22.gameObject.SetActive(true);
            coins23.gameObject.SetActive(true);
            coins24.gameObject.SetActive(true);
            coins25.gameObject.SetActive(true);
            coins26.gameObject.SetActive(true);
            coins27.gameObject.SetActive(true);
            coins28.gameObject.SetActive(true);
            coins29.gameObject.SetActive(true);
            kam = 0;
            count = count - 10;

        }

    }
}
