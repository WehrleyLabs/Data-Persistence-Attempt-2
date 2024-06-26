using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class MenuUIScript2 : MonoBehaviour
{
    public TextMeshProUGUI YouWinText;
    private string recallPlayerName;
    
    // Start is called before the first frame update
    void Start()
    {
        MainManagerScript.Instance.LoadName();
        recallPlayerName = MainManagerScript.Instance.PlayerName;
        YouWinText.SetText("Hurray, " + recallPlayerName + "!  You win!");
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
