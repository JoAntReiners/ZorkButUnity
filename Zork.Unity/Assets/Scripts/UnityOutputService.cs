using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Zork;

public class UnityOutputService : MonoBehaviour, IOutputService
{
    [SerializeField]
    private TextMeshProUGUI TextLine;

    [SerializeField]
    private Transform Content;

    [SerializeField]
    private int MaxTextLines = 60;

    private List<GameObject> TextLines = new List<GameObject>();

    public void Clear()
    {
        //throw new System.NotImplementedException();
    }

    public void Write(string value)
    {
        //throw new System.NotImplementedException();
    }

    public void Write(object value) => Write(value.ToString());

    public void WriteLine(string value)
    {
        if (TextLines.Count >= MaxTextLines)
        {
            Destroy(TextLines[0]);
            TextLines.RemoveAt(0);
        }

        var textLine = Instantiate(TextLine, new Vector3(100, -50, 0), Quaternion.identity, Content);
        textLine.text = value;
        TextLines.Add(textLine.gameObject);
    }

    public void WriteLine(object value) => WriteLine(value.ToString());

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
