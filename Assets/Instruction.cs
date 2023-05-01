using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instruction : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene("Main_menu_scene");
    }

}
