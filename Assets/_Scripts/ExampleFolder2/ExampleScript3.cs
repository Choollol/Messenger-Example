using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript3 : MonoBehaviour
{
    [SerializeField] private GameObject objectPrefab;
    private void Start()
    {
        DataMessenger.SetGameObject("ObjectPrefab", objectPrefab);
        EventMessenger.TriggerEvent("CreateObject");
        Debug.Log(DataMessenger.GetGameObject("ObjectInstance"));
    }
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
        transform.position += new Vector3(1, 0);
    }
}


