﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopWatch : MonoBehaviour
{

    Text text;
    float theTime;
    public float speed = 1;
    public bool playing;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playing == true)
        {
            theTime += Time.deltaTime * speed;
            string hours = Mathf.Floor((theTime % 216000) / 3600).ToString("00");
            string minutes = Mathf.Floor((theTime % 3600) / 60).ToString("00");
            string seconds = (theTime % 60).ToString("00");
            if (text != null)
            {
                text.text = hours + ":" + minutes + ":" + seconds;
            }
        }
    }

    public void ClickPlay()
    {
        theTime = 0;
        playing = true;
    }

    public void ClickStop()
    {
        playing = false;
    }
}