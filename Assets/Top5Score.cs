using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Top5Score : MonoBehaviour
{
    public const int NUM_HIGH_SCORES = 5;
    public const string NAME_KEY = "HSName";
    public const string SCORE_KEY = "HScore";
    public const string SPSCORE_KEY = "HSSpScore";
    [SerializeField] string playerName;
    [SerializeField] int playerScore;
    [SerializeField] int spScore;

    [SerializeField] TMP_Text[] nameTexts;
    [SerializeField] TMP_Text[] scoreTexts;
    [SerializeField] TMP_Text[] spScoreTexts;

    // Start is called before the first frame update
    void Start()
    {
        playerName = PersistentData.Instance.GetName();
        playerScore = PersistentData.Instance.GetScore();
        spScore = PersistentData.Instance.GetSpScore();

        SaveScore();
        DisplayHighScores();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SaveScore()
    {
        for (int i = 1; i <= NUM_HIGH_SCORES; i++)
        {
            string currentNameKey = NAME_KEY + i;
            string currentScoreKey = SCORE_KEY + i;
            string currentSpScoreKey = SPSCORE_KEY + i;

            if (PlayerPrefs.HasKey(currentScoreKey))
            {
                int currentScore = PlayerPrefs.GetInt(currentScoreKey);
                int currentSpScore = PlayerPrefs.GetInt(currentSpScoreKey);
                if (playerScore > currentScore)
                {
                    int tempScore = currentScore;
                    string tempName = PlayerPrefs.GetString(currentNameKey);
                    int tempSpScore = currentSpScore;

                    PlayerPrefs.SetString(currentNameKey, playerName);
                    PlayerPrefs.SetInt(currentScoreKey, playerScore);
                    PlayerPrefs.SetInt(currentSpScoreKey, spScore);

                    playerName = tempName;
                    playerScore = tempScore;
                    spScore = tempSpScore;
                }
            }
            else

            {
                PlayerPrefs.SetString(currentNameKey, playerName);
                PlayerPrefs.SetInt(currentScoreKey, playerScore);
                PlayerPrefs.SetInt(currentSpScoreKey, spScore);
                return;
            }
        }
    }

    public void DisplayHighScores()
    {
        for (int i = 0; i < NUM_HIGH_SCORES; i++)
        {
            nameTexts[i].text = "Name: " + PlayerPrefs.GetString(NAME_KEY + (i + 1));
            scoreTexts[i].text = "Score: " + PlayerPrefs.GetInt(SCORE_KEY + (i + 1)).ToString();
            spScoreTexts[i].text = ": " + PlayerPrefs.GetInt(SPSCORE_KEY + (i + 1)).ToString();
        }
    }
}