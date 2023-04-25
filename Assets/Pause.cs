using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{

    public bool isPaused = false;

    public GameObject pauseMenu;
    public GameObject shopMenu;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("main_menu_scene");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Shop()
    {
        shopMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void leaveShop()
    {
        shopMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
}
