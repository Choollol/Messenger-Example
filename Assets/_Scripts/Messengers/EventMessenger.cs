using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;

// Allows communication of events across AssemblyDefinitions
public class EventMessenger : MonoBehaviour
{

    private Dictionary<string, UnityEvent> eventDictionary;

    private static EventMessenger instance;

    public static EventMessenger Instance
    {
        get
        {
            if (!instance)
            {
                instance = FindObjectOfType(typeof(EventMessenger)) as EventMessenger;

                if (!instance)
                {
                    Debug.LogError("There needs to be one active EventMessenger script on a GameObject in your scene.");
                }
                else
                {
                    instance.Init();
                }
            }

            return instance;
        }
    }

    void Init()
    {
        if (eventDictionary == null)
        {
            eventDictionary = new Dictionary<string, UnityEvent>();
        }
    }

    /// <summary>
    /// Associates a function with an event. Put this in OnEnable.
    /// </summary>
    /// <param name="eventName">The name of the event to be listened for. The same name will be used when triggereing the event.</param>
    /// <param name="listener">The function to be called when the event is triggered.</param>
    /// <returns></returns>
    public static void StartListening(string eventName, UnityAction listener)
    {
        UnityEvent thisEvent = null;
        if (Instance.eventDictionary.TryGetValue(eventName, out thisEvent))
        {
            thisEvent.AddListener(listener);
        }
        else
        {
            thisEvent = new UnityEvent();
            thisEvent.AddListener(listener);
            Instance.eventDictionary.Add(eventName, thisEvent);
        }
    }

    /// <summary>
    /// For every StartListening call, put a corresponding StopListening call in OnDisable too.
    /// </summary>
    /// <param name="eventName">The name of the event.</param>
    /// <param name="listener">The function to stop listening to.</param>
    /// <returns></returns>
    public static void StopListening(string eventName, UnityAction listener)
    {
        if (instance == null) return;
        UnityEvent thisEvent = null;
        if (Instance.eventDictionary.TryGetValue(eventName, out thisEvent))
        {
            thisEvent.RemoveListener(listener);
        }
    }

    /// <summary>
    /// Triggers an event through a given event name. All functions listening to the event will be invoked.
    /// </summary>
    /// <param name="eventName">The name of the event to trigger.</param>
    public static void TriggerEvent(string eventName)
    {
        UnityEvent thisEvent = null;
        if (Instance.eventDictionary.TryGetValue(eventName, out thisEvent))
        {
            thisEvent.Invoke();
        }
        else
        {
            Debug.Log("EventMessenger does not contain " + eventName);
        }
    }
}