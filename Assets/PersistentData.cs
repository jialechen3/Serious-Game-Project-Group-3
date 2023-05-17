using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentData : MonoBehaviour
{
    [SerializeField] int playerScore;
    [SerializeField] string playerName;
    [SerializeField] int specialScore;

    public static PersistentData Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(this);
            Instance = this;
        }

        else
            Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        playerName = "";
        playerScore = 0;
        specialScore = 0;
        
    }
    public void SetName(string name)
    {
        playerName = name;
    }

    public void SetScore(int score)
    {
        playerScore = score;
    }

    public void SetSpecialScore(int spScore)
    {
        specialScore = spScore;
    }

    public string GetName()
    {
        return playerName;
    }

    public int GetScore()
    {
        return playerScore;
    }

    public int GetSpScore()
    {
        return specialScore;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
