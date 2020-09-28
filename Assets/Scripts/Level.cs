using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public static Level instance;
    [SerializeField] Transform stack;
    public int objectInScene;
    public int totalObjects;

    void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
    }
   
    void Start()
    {
        countObject();
    }

    void countObject()
    {
        totalObjects = stack.childCount;
        objectInScene = totalObjects;
    }

   
    void Update()
    {
        
    }
}
