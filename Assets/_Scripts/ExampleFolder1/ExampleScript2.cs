using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript2 : MonoBehaviour
{
    private void Start()
    {
        EventMessenger.TriggerEvent("EventName");
    }
}

