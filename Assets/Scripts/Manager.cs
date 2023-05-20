using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class Manager : MonoBehaviour
{
    int score;
    int spScore;
    [SerializeField] TMP_Text specialScore;
    [SerializeField] TMP_Text scoreTxt;
    
    
    
    int currentLevel;

    void Start()
    {
        score = PersistentData.Instance.GetScore();
        spScore = PersistentData.Instance.GetSpScore();
        DisplayScore();
 
    }
    // void wrongAnswer()
   // {
    //    ResetScreen.SetActive(true);
    //}
    void Update()
    {
        score = PersistentData.Instance.GetScore();
        spScore = PersistentData.Instance.GetSpScore();
        DisplayScore();

    }
    public void ResetGame()
    {
        SceneManager.LoadScene("Scene_2");
    }

    
    
    public void DeductPoints() {
        score -= 1;
        PersistentData.Instance.SetScore(score);
        Debug.Log("Score: " + score);
        DisplayScore();
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
        scoreTxt.text = "Score: " + score.ToString();
        specialScore.text = spScore.ToString();
        //bulletTxt.text = ": " + bulletNum;
    }

}
