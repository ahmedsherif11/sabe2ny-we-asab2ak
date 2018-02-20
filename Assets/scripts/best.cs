using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class best : MonoBehaviour
{

    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;

    public GameObject LapTimeBox;

    void OnTriggerEnter()
    {

        if (timer.SecondCount <= 9)
        {
            SecondDisplay.GetComponent<Text>().text = "0" + timer.SecondCount + ".";
        }
        else
        {
            SecondDisplay.GetComponent<Text>().text = "" + timer.SecondCount + ".";
        }

        if (timer.MinuteCount <= 9)
        {
            MinuteDisplay.GetComponent<Text>().text = "0" + timer.MinuteCount + ".";
        }
        else
        {
            MinuteDisplay.GetComponent<Text>().text = "" + timer.MinuteCount + ".";
        }

        MilliDisplay.GetComponent<Text>().text = "" + timer.MilliCount;

        timer.MinuteCount = 0;
        timer.SecondCount = 0;
        timer.MilliCount = 0;

        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);
    }

}