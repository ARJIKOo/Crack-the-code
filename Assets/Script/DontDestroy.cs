using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    void Awake()
    {
        
        GameObject[] objs = GameObject.FindGameObjectsWithTag("DontDestroy");

        if (objs.Length > 1)
        {
            
            Destroy(this.gameObject);
        }
        else
        {
            
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
