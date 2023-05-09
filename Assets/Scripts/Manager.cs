using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class Manager : MonoBehaviour
{
    int score;
    [SerializeField] TMP_Text scoreTxt;
    public GameObject[] Levels;
    public GameObject ResetScreen,End; 
    
    int currentLevel;

    void Start()
    {
        score = PersistentData.Instance.GetScore();
        DisplayScore();
 
    }
    // void wrongAnswer()
   // {
    //    ResetScreen.SetActive(true);
    //}
    void Update()
    {
        score = PersistentData.Instance.GetScore();
        
    }
    public void ResetGame()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    
    public void correctAnswer()
    {
        AddPoints();
        if(currentLevel + 1 != Levels.Length)
        {
            Levels[currentLevel].SetActive(false);

            currentLevel++;
            Levels[currentLevel].SetActive(true);
        }
        else
        {
            Levels[currentLevel].SetActive(false);
           
        }
    }

    public void AddPoints() {
        score += 1;
        PersistentData.Instance.SetScore(score);
        Debug.Log("Score: " + score);
        DisplayScore();
    }

    public void HighScore() {
        SceneManager.LoadScene("ScoreScene");
    }

    public void DisplayScore()
    {
        scoreTxt.text = ": " + score;
        //bulletTxt.text = ": " + bulletNum;
    }

}
