using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject currentLevel;
    public Manager controller;
    public GameObject A;
    public GameObject B;
    public GameObject C;
    public GameObject D;
    public GameObject infor;
    private GameObject currentObject;
    public int numChoices;


    //this will allow players to use the keyboard during quiz and fact scenes
    //1 = a, 2 = b, 3 = c. 4 = d
    //Numeric keypad = Keypad
    //alphanumeric keyboard = Alpha

    //enter = next or the singular button in fact and score scenes
    void Update()
    {
        if(numChoices > 1)
        {

            if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
                ChoiceA();

            if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))
                ChoiceB();

            if(numChoices > 2)
            {
                if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3))
                    ChoiceC();

                if(numChoices > 3)
                {
                    if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4))
                        ChoiceD();
                }
            }

        }else if(numChoices == 1)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (currentLevel != null)
                    currentObject = currentLevel;

                if (currentLevel.tag == "WrongChoice")
                    GoNextWrong();

                if (currentLevel.tag == "CorrectChoice")
                    GoNextRight();

                else
                    GoBack();
            }
        }
    }


    private void Answer(GameObject str) {
        currentObject = str;
        currentLevel.SetActive(false);
        str.SetActive(true);
    }
    public void ChoiceA() {
        Answer(A);
    }

    public void ChoiceB() {
        Answer(B);
    }

    public void ChoiceC() {
        Answer(C);
    }
    
    public void ChoiceD() {
        Answer(D);
    }
    
    public void GoBack() {
        infor.SetActive(false);
    }

    public void GoNextRight() {
        currentObject.SetActive(false);
        infor.SetActive(true);
        controller.AddPoints();
    }

    public void GoNextWrong() {
        currentObject.SetActive(false);
        infor.SetActive(true);
        controller.DeductPoints();
    }
    public void GoToLosHotel() {
        SceneManager.LoadScene("HotelScene");
    }

    public void HighScore() {
        SceneManager.LoadScene("ScoreScene");
    }

    public void GoToFightWithHomeless() {
        SceneManager.LoadScene("FightScene");
    }

    public void RejectScene() {
        SceneManager.LoadScene("RejectScene");
    }

}
