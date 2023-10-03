using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject LevelManager;
    public GameObject UIManager;

    private LevelManager _levelManager;
    private UIManager _UIManager;

    public enum GameState
    {
        Titlescreen,
        Pause,
        Level1,
        Level2,
        Level3
    }

    private GameState gameState;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) _levelManager.loadTitleScreen(); // press 1
        if (Input.GetKeyDown(KeyCode.Alpha2)) _levelManager.loadLevel1(); // press 2
        if (Input.GetKeyDown(KeyCode.Alpha3)) _levelManager.loadLevel2(); // press 3
        if (Input.GetKeyDown(KeyCode.Alpha4)) _levelManager.loadLevel3(); // press 4
    }
}
