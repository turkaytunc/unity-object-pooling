using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    private static ObjectPool objectPoolInstance;


    private void Awake()
    {
        if (objectPoolInstance == null)
        {
            objectPoolInstance = this;
        }
        else if(objectPoolInstance != this)
        {
            Debug.Log("More than one pool instance");
        }

    }


}
