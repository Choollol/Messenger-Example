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
    private static Dictionary<string, List<string>> stringLists;
    private static Dictionary<string, bool> bools;
    private static Dictionary<string, Vector3> vector3s;
    private static Dictionary<string, Quaternion> quaternions;

    private static int defaultIntValue = 0;
    private static float defaultFloatValue = 0;
    private static bool defaultBoolValue = false;
    private static string defaultStringValue = string.Empty;
    private static List<string> defaultStringListValue = new List<string>();
    private static Vector3 defaultVector3Value = Vector3.zero;

    private void Awake()
    {
        floats = new Dictionary<string, float>();
        ints = new Dictionary<string, int>();
        strings = new Dictionary<string, string>();
        stringLists = new Dictionary<string, List<string>>();
        bools = new Dictionary<string, bool>();
        vector3s = new Dictionary<string, Vector3>();
        quaternions = new Dictionary<string, Quaternion>();
    }
    public static float GetFloat(string key)
    {
        if (!floats.TryGetValue(key, out float v))
        {
            floats[key] = defaultFloatValue;
            return floats[key];
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
                SetFloat(key, GetFloat(key) + value);
                break;
            case '*':
                SetFloat(key, GetFloat(key) * value);
                break;
            case '/':
                SetFloat(key, GetFloat(key) / value);
                break;
        }
        return floats[key];
    }
    public static int GetInt(string key)
    {
        if (!ints.TryGetValue(key, out int v))
        {
            ints[key] = defaultIntValue;
            return ints[key];
        }
        return v;
    }
    public static void SetInt(string key, int value)
    {
        ints[key] = value;
    }
    /// <summary>
    /// Performs an operation on the int associated with the given key with the int given. The operator is + by default.
    /// </summary>
    public static int OperateInt(string key, int value, char op = '+')
    {
        switch (op)
        {
            case '+':
                SetInt(key, GetInt(key) + value);
                break;
            case '*':
                SetInt(key, GetInt(key) * value);
                break;
            case '/':
                SetInt(key, GetInt(key) / value);
                break;
        }
        return ints[key];
    }

    /// <summary>
    /// Performs an operation on the int associated with the given key with the float given. The operator is + by default.
    /// </summary>
    public static int OperateInt(string key, float value, char op = '+')
    {
        switch (op)
        {
            case '+':
                SetInt(key, (int)(GetInt(key) + value));
                break;
            case '*':
                SetInt(key, (int)(GetInt(key) * value));
                break;
            case '/':
                SetInt(key, (int)(GetInt(key) / value));
                break;
        }
        return ints[key];
    }

    public static string GetString(string key)
    {
        if (!strings.TryGetValue(key, out string v))
        {
            strings[key] = defaultStringValue;
            return strings[key];
        }
        return v;
    }
    public static void SetString(string key, string value)
    {
        strings[key] = value;
    }
    public static List<string> GetStringList(string key)
    {
        if (!stringLists.TryGetValue(key, out List<string> v))
        {
            stringLists[key] = defaultStringListValue;
            return stringLists[key];
        }
        return v;
    }
    public static void SetStringList(string key, List<string> value)
    {
        stringLists[key] = value;
    }
    public static bool GetBool(string key)
    {
        if (!bools.TryGetValue(key, out bool v))
        {
            bools[key] = defaultBoolValue;
            return bools[key];
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
            vector3s[key] = defaultVector3Value;
            return vector3s[key];
        }
        return v;
    }
    public static void SetVector3(string key, Vector3 value)
    {
        vector3s[key] = value;
    }
    public static Quaternion GetQuaternion(string key)
    {
        if (!quaternions.TryGetValue(key, out Quaternion v))
        {
            quaternions[key] = Quaternion.identity;
            return quaternions[key];
        }
        return v;
    }
    public static void SetQuaternion(string key, Quaternion value)
    {
        quaternions[key] = value;
    }
}