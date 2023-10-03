using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;

public class Singleton : MonoBehaviour
{

    public static Singleton Instance;

    public float health;
    public float experience;
    public float score;
    public string pName;
    public int timesLaunched;
    public int scenesSwitched;

    public static int numberOfGManagers;

    GUIStyle fontStyle = new GUIStyle();

    // Start is called before the first frame update
    void Start() //touch on .Additive if possible?
    {
        if (Instance != null)
        {
            GameObject.Destroy(gameObject); //destroys the GameManager if it already exists on start
        }
        else
        {
            GameObject.DontDestroyOnLoad(gameObject); //otherwise makes a GameManager that doesn't destroy between scenes
            Instance = this;
            loadSave();
            timesLaunched++;
            numberOfGManagers++;
        }
    }

    private void OnGUI()
    {
        fontStyle.fontSize = 20;
        GUI.Label(new Rect(10, 10, 100, 30), "Health: " + health, fontStyle);
        GUI.Label(new Rect(10, 40, 150, 30), "Experience: " + experience, fontStyle);
        GUI.Label(new Rect(10, 70, 100, 30), "Score: " + score, fontStyle);
        GUI.Label(new Rect(10, 100, 100, 30), "Name: " + pName, fontStyle);
        GUI.Label(new Rect(10, 130, 150, 30), "# of Times Launched: " + timesLaunched, fontStyle);
        GUI.Label(new Rect(10, 160, 150, 30), "# of Scenes Switched: " + scenesSwitched, fontStyle);

        GUI.Label(new Rect(10, 200, 150, 30), "# of Game Managers: " + numberOfGManagers, fontStyle);
    }
    
    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

        PlayerData data = new PlayerData();

        data.health = health;
        data.experience = experience;
        data.score = score;
        data.pName = pName;
        data.timesLaunched = timesLaunched;
        data.scenesSwitched = scenesSwitched;

        bf.Serialize(file, data);
        file.Close();

    }

    public void loadSave()
    {
        if(File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            health = data.health;
            experience = data.experience;
            score = data.score;
            pName = data.pName;
            timesLaunched = data.timesLaunched;
            scenesSwitched = data.scenesSwitched;
        } 
    }

    public void loadSaveIngame()
    {
        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            health = data.health;
            experience = data.experience;
            score = data.score;
            pName = data.pName;
        }
    }
}

[Serializable]
class PlayerData
{
    public float health;
    public float experience;
    public float score;
    public string pName;
    public int timesLaunched;
    public int scenesSwitched;

    public int currentScene;
}
