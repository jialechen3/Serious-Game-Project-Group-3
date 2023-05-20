using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.EventSystems;

public class Menu : MonoBehaviour
{
    [SerializeField]  TMP_InputField playerNameInput;

    void Start()
    {
        playerNameInput.text = PersistentData.Instance.GetName();
    }
    public void PlayGame()
    {
        string playerName = playerNameInput.text;
        PersistentData.Instance.SetName(playerName);
        PersistentData.Instance.SetScore(0);
        PersistentData.Instance.SetSpecialScore(0);
        SceneManager.LoadScene("Scene_2");
    }
    public void Instruction()
    {
        SceneManager.LoadScene("HowToPlay");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Setting()
    {
        SceneManager.LoadScene("Setting");
    }
    public void TopScore()
    {
        SceneManager.LoadScene("ScoreScene");
    }
    
}
