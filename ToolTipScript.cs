﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolTipScript : MonoBehaviour
{
    public Text helpText;
    public Text tooltipText;

    public string helpString;
    public string tooltipString;

    void Start()
    {
        helpText = GameObject.Find("HelpText").GetComponent<Text>();
        tooltipText = GameObject.Find("ToolTipText").GetComponent<Text>();
    }

    void Update()
    {

    }

    void OnVREnter()
    {
        helpText.text = helpString;
        tooltipText.text = tooltipString;
    }

    void OnVRExit()
    {
        helpText.text = "";
        tooltipText.text = "";
    }
}
