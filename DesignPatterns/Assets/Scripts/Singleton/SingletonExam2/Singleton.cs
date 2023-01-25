using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    string text;
    private static Singleton instance = null;
    public int pin = 12345;



    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameObject("Singleton").AddComponent<Singleton>();
            }
            return instance;
        }

    }
    private void Awake()
    {
        if (instance != null) Destroy(this);
        DontDestroyOnLoad(this);
    }

    void OnEnable()
    {
        instance = this;
        text = "Hello World";
    }

    public string GetText()
    {
        return text;
    }

}
