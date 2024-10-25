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
        // Previous example
        //Debug.Log("Function Called");

        Debug.Log(DataMessenger.GetString("StringToPrint"));
    }
}



