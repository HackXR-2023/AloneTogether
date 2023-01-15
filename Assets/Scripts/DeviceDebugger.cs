using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeviceDebugger : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    void Start() 
    {
       tmp = GameObject.FindGameObjectWithTag("debugger").GetComponentInChildren<TextMeshProUGUI>();
    }
    
    public void Debug(string message) 
    {
       tmp.text = message;
    }
}
