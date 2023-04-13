using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class InGame : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene("Scene_1");
    }
}
