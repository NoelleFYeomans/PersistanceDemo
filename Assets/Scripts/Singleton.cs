using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{

    static Singleton Instance;

    // Start is called before the first frame update
    void Start()
    {
        if (Instance != null)
        {
            GameObject.Destroy(gameObject); //destroys the GameManager if it already exists on start
        }
        else
        {
            GameObject.DontDestroyOnLoad(gameObject); //otherwise makes a GameManager that doesn't destroy between scenes
            Instance = this;
        }
    }
}
