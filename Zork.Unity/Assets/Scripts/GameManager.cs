using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Zork;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private string ZorkGameFileAssetName = "Zork";

    [SerializeField]
    private UnityOutputService Output;

    void Awake()
    {
        TextAsset gameJsonAsset = Resources.Load<TextAsset>(ZorkGameFileAssetName);
        Game.Start(gameJsonAsset.text, Output);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
