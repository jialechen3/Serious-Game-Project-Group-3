using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpecialText : MonoBehaviour
{
    [SerializeField] TMP_Text instructionTexts;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If we triggerd the player enable playerdeteced and show indicator
        if (collision.tag == "Player")
        {
            instructionTexts.text = "There is Nothing behind!!!";

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //If we lost trigger  with the player disable playerdeteced and hide indicator
        if (collision.tag == "Player")
        {
            instructionTexts.text = "";
        }
    }
}
