using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ButtonFuntion : MonoBehaviour
{
    [SerializeField] InputField playerNameInput;
    // Start is called before the first frame update
    void Start()
    {
        playerNameInput.text = PersistentData.Instance.GetName();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        string playerName = playerNameInput.text;
        PersistentData.Instance.SetName(playerName);
        SceneManager.LoadScene("Scene_2");
    }
}
