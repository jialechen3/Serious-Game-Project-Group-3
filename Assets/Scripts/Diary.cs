using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diary : MonoBehaviour
{
    [SerializeField] GameObject diary;
    private bool isOpen = false;

    [SerializeField] Book bookScript;
    [SerializeField] Sprite [] bookPages;
    [SerializeField] LevelManager levelManagerScript1;
    [SerializeField] LevelManager levelManagerScript2;
    [SerializeField] bool isActive1;
    [SerializeField] bool isActive2;
    [SerializeField] Sprite[] swapPages = new Sprite[6];
    // Start is called before the first frame update
    int index = 0;
   
    private void Awake()
    {
        diary = GameObject.FindGameObjectWithTag("diary");
        //isActive1 = levelManagerScript1.isActive;
        Debug.Log(isActive1);
        //isActive2 = levelManagerScript1.isActive;
        
    }
    void Start()
    {
        
        
        bookPages = bookScript.bookPages;
        //diary.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (isOpen)
            {
                CloseDiary();
            }
            else
            {
                OpenDiary();
            }
        }
        

    }

    void OpenDiary()
    {
        diary.SetActive(true);
        isOpen = true;
        Time.timeScale = 0f;
       

    }

    void CloseDiary()
    {
        diary.SetActive(false);
        isOpen = false;
        Time.timeScale = 1f;
        
    }

    public void SwapPages()
    {
        if (!isActive1)
        {
            bookPages[index] = swapPages[index];
            index++;
            Debug.Log("Function called");
        }
        if (!isActive2)
        {
            bookPages[index] = swapPages[index];
            index++;
            Debug.Log("Function called");
        }

    }

   


}
