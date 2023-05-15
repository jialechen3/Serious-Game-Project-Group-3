using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DialogueTrigger : MonoBehaviour
{
    public Dialogue1 dialogueScript;
    private bool playerDetected;
    [SerializeField] TMP_Text instructionTexts;

    //Detect trigger with player
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If we triggerd the player enable playerdeteced and show indicator
        if(collision.tag == "Player")
        {
            instructionTexts.text = "Press E To Interact";
            playerDetected = true;
            dialogueScript.ToggleIndicator(playerDetected);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //If we lost trigger  with the player disable playerdeteced and hide indicator
        if (collision.tag == "Player")
        {
            instructionTexts.text = "";
            playerDetected = false;
            dialogueScript.ToggleIndicator(playerDetected);
            dialogueScript.EndDialogue();
        }
    }
    //While detected if we interact start the dialogue
    private void Update()
    {
        if(playerDetected && Input.GetKeyDown(KeyCode.E))
        {
            dialogueScript.StartDialogue();
        }
    }
}
