using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonActive : MonoBehaviour
{
    public GameObject StartButton;
    public GameObject StopButton;
    public GameObject Targets;
    public Text Text;

    public bool gameActive = false;

    void OnMouseDown()
    {
        Debug.Log("Start!");
        
        
        StartButton.SetActive(false);
        Text.GetComponent<StopWatch>().ClickPlay();
        Targets.GetComponent<DummyMaker>().enemyTotal = 10;
        Targets.GetComponent<DummyMaker>().GameLoad();
        StopButton.SetActive(true);
    }
}
