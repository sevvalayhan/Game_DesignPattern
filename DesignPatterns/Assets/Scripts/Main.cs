using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
  
    void Start()
    {
        GameManager.Instance.a = 10;
    }

   
    void Update()
    {
        Debug.Log(GameManager.Instance.a);
        Debug.Log(Singleton.Instance.GetText());
    }
}
