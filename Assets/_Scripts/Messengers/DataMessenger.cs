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
    public static float GetFloat(string key)
    {
        if (!floats.TryGetValue(key, out float v))
        {
            floats[key] = 0;
            return 0;
        }
        return v;
    }
    public static void SetFloat(string key, float value)
    {
        floats[key] = value;
    }
    /// <summary>
    /// Performs an operation on the float associated with the given key with the value given. The operator is + by default.
    /// </summary>
    public static float OperateFloat(string key, float value, char op = '+')
    {
        switch (op)
        {
            case '+':
                floats[key] += value;
                break;
            case '*':
                floats[key] *= value;
                break;
            case '/':
                floats[key] /= value;
                break;
        }
        return floats[key];
    }
    public static int GetInt(string key)
    {
        if (!ints.TryGetValue(key, out int v))
        {
            ints[key] = 0;
            return 0;
        }
        return v;
    }
    public static void SetInt(string key, int value)
    {
        ints[key] = value;
    }
    /// <summary>
    /// Performs an operation on the int associated with the given key with the value given. The operator is + by default.
    /// </summary>
    public static int OperateInt(string key, int value, char op = '+')
    {
        switch (op)
        {
            case '+':
                ints[key] += value;
                break;
            case '*':
                ints[key] *= value;
                break;
            case '/':
                ints[key] /= value;
                break;
        }
        return ints[key];
    }
    public static string GetString(string key)
    {
        if (!strings.TryGetValue(key, out string v))
        {
            strings[key] = string.Empty;
            return string.Empty;
        }
        return v;
    }
    public static void SetString(string key, string value)
    {
        strings[key] = value;
    }
    public static bool GetBool(string key)
    {
        if (!bools.TryGetValue(key, out bool v))
        {
            bools[key] = false;
            return false;
        }
        return v;
    }
    public static void SetBool(string key, bool value)
    {
        bools[key] = value;
    }
    public static Vector3 GetVector3(string key)
    {
        if (!vector3s.TryGetValue(key, out Vector3 v))
        {
            vector3s[key] = Vector3.zero;
            return Vector3.zero;
        }
        return v;
    }
    public static void SetVector3(string key, Vector3 value)
    {
        vector3s[key] = value;
    }
}