using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int returnStartScene()
    {
        return SceneManager.GetActiveScene().buildIndex;
    }
    public void loadTitleScreen() //perhaps make a single scene load method that takes in an input rather than hardcode level loads
    {
        SceneManager.LoadScene(0);
        Singleton.Instance.scenesSwitched++;
        Debug.Log("Titlescreen");
    }

    public void loadLevel1()
    {
        SceneManager.LoadScene(1);
        Singleton.Instance.scenesSwitched++;
        Debug.Log("level 1");
    }
    public void loadLevel2()
    {
        SceneManager.LoadScene(2);
        Singleton.Instance.scenesSwitched++;
        Debug.Log("level 2");
    }
    public void loadLevel3()
    {
        SceneManager.LoadScene(3);
        Singleton.Instance.scenesSwitched++;
        Debug.Log("level 3");
    }

    public void quitGame()
    {
        Application.Quit();
        Debug.Log("you quit btw");
    }
}
