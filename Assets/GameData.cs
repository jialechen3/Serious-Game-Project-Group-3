using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameData : MonoBehaviour
{
    [SerializeField] string playerName;
    [SerializeField] int score;
    [SerializeField] TMP_Text nameText;
    [SerializeField] TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        playerName = PersistentData.Instance.GetName();
        score = PersistentData.Instance.GetScore();
        nameText.text = "Hi, " + playerName;
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
