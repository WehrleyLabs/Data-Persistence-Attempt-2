using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerNameInput : MonoBehaviour
{
    public TMP_InputField userName;
    public string output;

    public void TurnInputIntoText()
    {
        output = userName.text;
        MainManagerScript.Instance.PlayerName = output;
        MainManagerScript.Instance.SaveName();
        Debug.Log(output);
    }
}
