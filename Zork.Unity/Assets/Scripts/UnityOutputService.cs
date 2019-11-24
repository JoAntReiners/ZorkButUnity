using System;
using UnityEngine;
using Zork;

public class UnityOutputService : MonoBehaviour, IOutputService
{
    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public void Write(string value)
    {
        throw new System.NotImplementedException();
    }

    public void Write(object value) => Write(value.ToString());

    public void WriteLine(string value)
    {
        throw new System.NotImplementedException();
    }

    public void WriteLine(object value) => WriteLine(value.ToString());

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
