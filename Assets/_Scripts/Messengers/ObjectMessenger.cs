using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Allows communication of objects across AssemblyDefinitions
public class ObjectMessenger : MonoBehaviour
{
    private static Dictionary<string, GameObject> gameObjects;
    private static Dictionary<string, ScriptableObject> scriptableObjects;

    private void Awake()
    {
        gameObjects = new Dictionary<string, GameObject>();
        scriptableObjects = new Dictionary<string, ScriptableObject>();
    }
    public static GameObject GetGameObject(string key)
    {
        if (gameObjects.TryGetValue(key, out GameObject obj))
        {
            return obj;
        }
        else
        {
            return null;
        }
    }
    public static void SetGameObject(string key, GameObject obj)
    {
        if (gameObjects.TryGetValue(key, out _))
        {
            gameObjects[key] = obj;
        }
        else
        {
            gameObjects.Add(key, obj);
        }
    }
    public static ScriptableObject GetScriptableObject(string key)
    {
        if (scriptableObjects.TryGetValue(key, out ScriptableObject obj))
        {
            return obj;
        }
        else
        {
            return null;
        }
    }
    public static void SetScriptableObject(string key, ScriptableObject obj)
    {
        if (scriptableObjects.TryGetValue(key, out _))
        {
            scriptableObjects[key] = obj;
        }
        else
        {
            scriptableObjects.Add(key, obj);
        }
    }
}