using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Zork;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI LocationText;

    [SerializeField]
    private TextMeshProUGUI ScoreText;

    [SerializeField]
    private TextMeshProUGUI MovesText;

    [SerializeField]
    private string ZorkGameFileAssetName = "Zork";

    [SerializeField]
    private UnityOutputService OutputService;

    [SerializeField]
    private UnityInputService InputService;

    void Awake()
    {
        TextAsset gameJsonAsset = Resources.Load<TextAsset>(ZorkGameFileAssetName);
        Game.Start(gameJsonAsset.text, InputService, OutputService);
        Game.Instance.CommandManager.PerformCommand(Game.Instance, "LOOK");
    }

    void Start()
    {
        
    }

    void Update()
    {
        LocationText.text = Game.Instance.Player.LocationName;
        ScoreText.text = "Score: " + Game.Instance.Player.Score;
        MovesText.text = "Moves: " + Game.Instance.Player.Moves;
    }
}
