using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class ShowText : MonoBehaviour
{

    public string textValue = "America has recently lost their job and attempted to find one quickly."
            + " \n\nHowever, because of how little the last job paid they couldn't cover expenses and missed countless rent payments."
            + " \n\nThey have been kicked out of their home and now roam the streets.";

    /*public string textValue = "hello there player!";*/

    public TMP_Text textElement;

    // Start is called before the first frame update
    void Start()
    {
        textElement.text = textValue;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
