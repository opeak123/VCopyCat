using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoWeekSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance = null;

    public static T Instance
    {
        get
        {
            return instance;
        }
    }

    protected void Awake()
    {
        instance = this as T;
    }
}
