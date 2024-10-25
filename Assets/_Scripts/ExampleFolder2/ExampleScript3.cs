using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript3 : MonoBehaviour
{
    private void OnEnable()
    {
        EventMessenger.StartListening("EventName", AnotherFunction);
    }
    private void OnDisable()
    {
        EventMessenger.StopListening("EventName", AnotherFunction);
    }
    private void AnotherFunction()
    {
        transform.position += transform.forward;
    }
}


