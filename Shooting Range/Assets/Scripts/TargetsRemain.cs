using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetsRemain : MonoBehaviour
{
    public GameObject Targets;
    public Text TargetCounter;
    float targetCount;

    // Start is called before the first frame update
    void Start()
    {
        targetCount = Targets.GetComponent<DummyMaker>().targets;
    }

    // Update is called once per frame
    void Update()
    {
        TargetCounter.text = targetCount.ToString("00");
    }
}
