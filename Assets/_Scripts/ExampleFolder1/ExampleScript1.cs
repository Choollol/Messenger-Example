using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript1 : MonoBehaviour
{
    private void OnEnable()
    {
        EventMessenger.StartListening("EventName", SomeFunction);
        EventMessenger.StartListening("CreateObject", CreateObject);
    }
    private void OnDisable()
    {
        EventMessenger.StopListening("EventName", SomeFunction);
        EventMessenger.StopListening("CreateObject", CreateObject);
    }
    private void CreateObject()
    {
        DataMessenger.SetGameObject("ObjectInstance", 
            Instantiate(DataMessenger.GetGameObject("ObjectPrefab"), transform.position, Quaternion.identity));
    }
    private void SomeFunction()
    {
        // Previous example
        //Debug.Log("Function Called");

        Debug.Log(DataMessenger.GetString("StringToPrint"));
    }
}



