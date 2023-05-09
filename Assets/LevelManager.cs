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
    private GameObject currentObject;

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
        currentObject.SetActive(false);
        currentLevel.SetActive(true);
    }

    public void GoNext() {
        currentObject.SetActive(false);
        controller.correctAnswer();
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
