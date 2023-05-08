using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameData : MonoBehaviour
{
    [SerializeField] string playerName;
    [SerializeField] TMP_Text nameText;
    // Start is called before the first frame update
    void Start()
    {
        playerName = PersistentData.Instance.GetName();
        nameText.text = "Hi, " + playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
