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
        Level1,
        Level2,
        Level3
    }

    // Start is called before the first frame update
    void Start()
    {
        _levelManager = LevelManager.GetComponent<LevelManager>();
        _UIManager = UIManager.GetComponent<UIManager>();

        if (_levelManager.returnStartScene() == 0)
        {
            _UIManager.TitlescreenActive();
        }
        else if (_levelManager.returnStartScene() == 1)
        {
            _UIManager.Level1Active();
        }
        else if (_levelManager.returnStartScene() == 2)
        {
            _UIManager.Level2Active();
        }
        else if (_levelManager.returnStartScene() == 3)
        {
            _UIManager.Level3Active();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            _levelManager.loadTitleScreen();
            _UIManager.TitlescreenActive();
        } // press 0
        if (Input.GetKeyDown(KeyCode.Alpha1))
        { 
            _levelManager.loadLevel1();
            _UIManager.Level1Active();
        } // press 1
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _levelManager.loadLevel2();
            _UIManager.Level2Active();
        } // press 2
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _levelManager.loadLevel3();
            _UIManager.Level3Active();
        } // press 3
    }

    private void OnGUI()
    {
        //Health
        if(GUI.Button(new Rect(300, 10, 100, 30), "Health Up"))
        {
            Singleton.Instance.health += 10;
        }
        if (GUI.Button(new Rect(410, 10, 100, 30), "Health Down"))
        {
            Singleton.Instance.health -= 10;
        }
        //Experience
        if (GUI.Button(new Rect(300, 50, 100, 30), "EXP Up"))
        {
            Singleton.Instance.experience += 100;
        }
        if (GUI.Button(new Rect(410, 50, 100, 30), "EXP Down"))
        {
            Singleton.Instance.experience -= 100;
        }
        //Score
        if (GUI.Button(new Rect(300, 90, 100, 30), "Score Up"))
        {
            Singleton.Instance.score += 5;
        }
        if (GUI.Button(new Rect(410, 90, 100, 30), "Score Down"))
        {
            Singleton.Instance.score -= 5;
        }
        //Name
        if (GUI.Button(new Rect(300, 130, 100, 30), "Change Name"))
        {
            Singleton.Instance.pName = System.Environment.UserName;
        }
        //Save & Load
        if (GUI.Button(new Rect(300, 170, 100, 30), "Save"))
        {
            Singleton.Instance.Save();
        }
        if (GUI.Button(new Rect(410, 170, 100, 30), "Load"))
        {
            Singleton.Instance.loadSaveIngame();
        }
    }
}
