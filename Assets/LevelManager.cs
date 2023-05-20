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
