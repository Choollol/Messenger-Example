using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript2 : MonoBehaviour
{
    private void Start()
    {
        DataMessenger.SetFloat("SomeFloat", 1.5f);

        DataMessenger.SetString("StringToPrint", "Hello");

        DataMessenger.GetInt("SomeInt");

        DataMessenger.OperateInt("SomeInt", 1);

        DataMessenger.OperateFloat("SomeFloat", DataMessenger.OperateFloat("SomeFloat", 2), '*');

        EventMessenger.TriggerEvent("EventName");
    }
}

