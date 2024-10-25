using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// Allows for communication of data between scripts, decoupling
public class DataMessenger : MonoBehaviour
{
    private static Dictionary<string, float> floats;
    private static Dictionary<string, int> ints;
    private static Dictionary<string, string> strings;
    private static Dictionary<string, bool> bools;
    private static Dictionary<string, Vector3> vector3s;

    private void Awake()
    {
        floats = new Dictionary<string, float>();
        ints = new Dictionary<string, int>();
        strings = new Dictionary<string, string>();
        bools = new Dictionary<string, bool>();
        vector3s = new Dictionary<string, Vector3>();
    }
    public static float GetFloat(string key, float defaultValue=0)
    {
        if (!floats.TryGetValue(key, out float v))
        {
            floats[key] = defaultValue;
            return defaultValue;
        }
        return v;
    }
    public static void SetFloat(string key, float value)
    {
        floats[key] = value;
    }
    public static int GetInt(string key, int defaultValue=0)
    {
        if (!ints.TryGetValue(key, out int v))
        {
            ints[key] = defaultValue;
            return defaultValue;
        }
        return v;
    }
    public static void SetInt(string key, int value)
    {
        ints[key] = value;
    }
    public static string GetString(string key, string defaultValue="")
    {
        if (!strings.TryGetValue(key, out string v))
        {
            strings[key] = defaultValue;
            return defaultValue;
        }
        return v;
    }
    public static void SetString(string key, string value)
    {
        strings[key] = value;
    }
    public static bool GetBool(string key, bool defaultValue=false)
    {
        if (!bools.TryGetValue(key, out bool v))
        {
            bools[key] = defaultValue;
            return defaultValue;
        }
        return v;
    }
    public static void SetBool(string key, bool value)
    {
        bools[key] = value;
    }
    public static Vector3 GetVector3(string key, Vector3 defaultValue=new Vector3())
    {
        if (!vector3s.TryGetValue(key, out Vector3 v))
        {
            vector3s[key] = defaultValue;
            return defaultValue;
        }
        return v;
    }
    public static void SetVector3(string key, Vector3 value)
    {
        vector3s[key] = value;
    }
}