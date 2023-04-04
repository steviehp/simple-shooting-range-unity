using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopButton : MonoBehaviour
{
    public GameObject StartButton;
    public GameObject stopButton;
    public GameObject Targets;
    public Text Text;

    void OnMouseDown()
    {
        Debug.Log("Stop!");
        StartButton.SetActive(true);
        stopButton.SetActive(false);
        Text.GetComponent<StopWatch>().ClickStop();
        Targets.GetComponent<DummyMaker>().enemyTotal = 0;
        Targets.GetComponent<DummyMaker>().enemyCount = 0;
    }
}