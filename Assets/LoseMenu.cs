using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseMenu : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene("Scene_1");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Restart()
    {
        SceneManager.LoadScene("Scene_2");
    }
}
