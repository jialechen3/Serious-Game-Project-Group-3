using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FactsCheckForCorrectAnswer : MonoBehaviour
{
    [SerializeField] GameObject correctButtonClicked;
    [SerializeField] Button[] buttons;
    // Start is called before the first frame update
    
    
    void Start()
    {
        foreach (Button g in buttons)
            g.onClick.AddListener(delegate { WrongAnswerSingle(g); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CorrectAnswer()
    {
        correctButtonClicked.GetComponent<Image>().color = Color.green;
        Invoke("AllWrongAnswers", 1.0f);
        DisableButtons();
    }

    public void WrongAnswerSingle(Button button)
    {

        button.GetComponent<Image>().color = Color.red;
        Invoke("AllWrongAnswers", 1.0f);
        Invoke("CorrectAnswer", 1.0f);
        DisableButtons();
    }

    public void AllWrongAnswers()
    {
        foreach(Button g in buttons)
        {
            g.GetComponent<Image>().color = Color.red;

        }/**/
    }

    void DisableButtons()
    {
        foreach (Button g in buttons)
            g.GetComponent<Button>().enabled = false;

        correctButtonClicked.GetComponent<Button>().enabled = false;
    }

}
