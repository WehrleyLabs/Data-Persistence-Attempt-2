using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MainManagerScript : MonoBehaviour
{
    public static MainManagerScript Instance;

    public string PlayerName;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadName();
    }

    [System.Serializable]
    class NameData
    {
        public string PlayerName;
    }

    public void SaveName()
    {
        NameData playerNameData = new NameData();
        playerNameData.PlayerName = PlayerName;

        string json = JsonUtility.ToJson(playerNameData);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
        Debug.Log("Name " + PlayerName + " saved!");
    }

    public void LoadName()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            NameData playerNameData = JsonUtility.FromJson<NameData>(json);

            PlayerName = playerNameData.PlayerName;
        }
    }

}