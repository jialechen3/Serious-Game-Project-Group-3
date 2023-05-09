using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quiz : MonoBehaviour
{
    public void TopScore()
    {
        SceneManager.LoadScene("ScoreScene");
    }
}
