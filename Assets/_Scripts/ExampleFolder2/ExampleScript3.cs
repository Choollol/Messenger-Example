using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript3 : MonoBehaviour
{
    [SerializeField] private GameObject objectPrefab;
    private void Awake()
    {
        ObjectMessenger.SetGameObject("ObjectPrefab", objectPrefab);
        EventMessenger.TriggerEvent("CreateObject");
        Debug.Log(ObjectMessenger.GetGameObject("ObjectInstance"));
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


