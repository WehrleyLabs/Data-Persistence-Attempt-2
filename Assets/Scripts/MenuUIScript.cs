using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Events;

public class MenuUIScript : MonoBehaviour
{
    public string greetingPlayerName;
    public TextMeshProUGUI Greeting;

    // Start is called before the first frame update
    void Start()
    {
        MainManagerScript.Instance.LoadName();
        
        greetingPlayerName = MainManagerScript.Instance.PlayerName;
        Greeting.SetText("Hello, " + greetingPlayerName + "!  Welcome!");
    }

    public void NextScene()
    {
        SceneManager.LoadScene(1);
    }
    public void PreviousScene()
    {
        SceneManager.LoadScene(0);
    }

}
