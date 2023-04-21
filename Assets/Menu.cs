using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Scene_1");
    }
    public void Instruction()
    {
        SceneManager.LoadScene("HowToPlay");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
