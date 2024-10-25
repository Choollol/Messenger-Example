using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript1 : MonoBehaviour
{
    private void OnEnable()
    {
        EventMessenger.StartListening("EventName", SomeFunction);
    }
    private void OnDisable()
    {
        EventMessenger.StopListening("EventName", SomeFunction);
    }
    private void SomeFunction()
    {
        Debug.Log("Function Called");
    }
}



