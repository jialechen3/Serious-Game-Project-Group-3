using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    [SerializeField] TMP_Text instructionTexts;
    private bool playerDetected;
    public GameObject Door;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playerDetected && Input.GetKeyDown(KeyCode.E))
        {
            Door.SetActive(true);
        }

        if(Door.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                End();
            }
        }

    }
    public void End()
    {
        Door.SetActive(false);
        SceneManager.LoadScene("ScoreScene");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If we triggerd the player enable playerdeteced and show indicator
        if (collision.tag == "Player")
        {
            playerDetected = true;
            instructionTexts.text = "Back To Home Press E";

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //If we lost trigger  with the player disable playerdeteced and hide indicator
        if (collision.tag == "Player")
        {
            playerDetected = false;
            instructionTexts.text = "";
        }
    }
}
