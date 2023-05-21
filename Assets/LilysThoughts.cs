using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LilysThoughts : MonoBehaviour
{

    public TMP_Text thoughts;
    public TMP_Text pressInstructions;
    public GameObject nextButton;
    public GameObject previousButton;
    public TMP_Text instructions;
    GameObject instructionScene;

    GameObject[] storyObjects;
    GameObject[] instructionObjects;

    private float delayBeforeLoading = 5f;
    private float timeElapsed;

    public int placeInStory = 0;
    private bool hasSeenStory = false;

    public int placeInInstructions = 0;
    private bool inInstructions = false;
    private bool hasSeenInstructions = false;

    string currentThoughts = "I haven't seen dad after the nasty fight he had with mom. " +
        "Mom hasn't been herself either, she changed.\nEver since we lost our home, " +
        "mom began eating this weird candy.She doesn't let me have any though. ";

    string nextThoughts = "I wish we never left home.\nI feel lonely\nMom said I should " +
        "go out and find a way to live on my own.\nCan I really do that?\nCan I live on " +
        "my own?";

    string enter = "Next = Enter Key" +
        "\nPrevious = Shift Key";

    string enterWithoutShift = "Next = Enter Key";

    string pauseInstructions = "To Pause\n\tPress \"ESC\" On your Keyboard\n";

    string optionInstructions = "\nWhen you are given Options to choose from\n" +
        "\tPress \"1\" for choice A (left) and \"2\" for choie B (right)";

    string nextScene = "\n\nWhen you see a scene with one button, press \"Enter\" on your keyboard " +
        "as an alternative to pressing the button";

    // Start is called before the first frame update
    void Start()
    {
        pressInstructions.enabled = false;
        nextButton.SetActive(false);
        previousButton.SetActive(false);


        instructionObjects = GameObject.FindGameObjectsWithTag("Instructions");
        foreach (GameObject g in instructionObjects)
            g.SetActive(false);

    }

    private void FixedUpdate()
    {
       
       
    }

    // Update is called once per frame
    void Update()
    {

        if (hasSeenStory == false)
        {
            timeElapsed += Time.deltaTime;
            if (timeElapsed > delayBeforeLoading)
            {
                nextButton.SetActive(true);
                pressInstructions.enabled = true;
                if (placeInStory == 1)
                {
                    previousButton.SetActive(true);
                    hasSeenStory = true;
                }
            }
        }
        else
        {
            nextButton.SetActive(true);
            pressInstructions.enabled = true;
            if (placeInStory == 1 && inInstructions == false)
                previousButton.SetActive(true);
        }

        if (nextButton.activeSelf == true && pressInstructions.enabled == true)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                MoveToNextScene();
            }

            if(previousButton.activeSelf == true)
            {
                if (Input.GetKeyDown(KeyCode.RightShift) || Input.GetKeyDown(KeyCode.LeftShift))
                {
                    MoveToPreviousScene();
                }
            }
            
        }
    }


    public void MoveToNextScene()
    {
        if(placeInStory == 0)
        {
            timeElapsed = 0;
            nextButton.SetActive(false);
            pressInstructions.enabled = false;
            placeInStory++;

            thoughts.text = nextThoughts;
            pressInstructions.text = enter;
            pressInstructions.fontSize = 30;
        }
        else
        {
            if(placeInInstructions == 0)
            {

                previousButton.SetActive(false);

                storyObjects = GameObject.FindGameObjectsWithTag("Story");

                foreach (GameObject g in storyObjects)
                    g.SetActive(false);

                foreach (GameObject g in instructionObjects)
                    g.SetActive(true);

                inInstructions = true;

                pressInstructions.text = enterWithoutShift;

                placeInInstructions++;

                hasSeenInstructions = true;
            }
            else
            {
                previousButton.SetActive(true);

                pressInstructions.text = enter;
               
                instructions.text = pauseInstructions + optionInstructions
                    + nextScene;

                instructions.fontSize = 26;

                placeInInstructions++;
            }

            if(placeInInstructions > 2)
            {
                instructionScene = GameObject.FindGameObjectWithTag("InstructionScene");
                instructionScene.SetActive(false);
            }
            
        }
        
    }

    public void MoveToPreviousScene()
    {
        if(inInstructions == false)
        {
            placeInStory = 0;
            thoughts.text = currentThoughts;
            pressInstructions.text = enterWithoutShift;
            previousButton.SetActive(false);
        }
        else
        {

            placeInInstructions = 1;

            pressInstructions.text = enterWithoutShift;

            instructions.text = "To move your sprite:" +
            "\n\tMove Left = Left Arrow < or \"A\"" +
            "\n\tMove Right = Right Arrow > or \"D\"" +
            "\n\nTo Interact with NPC's:" +
            "\n\tPress \"E\"";

            instructions.fontSize = 36;

            previousButton.SetActive(false);
            
        }
        
    }

}
