using UnityEngine;
using UnityEngine.UI;

public class Journal : MonoBehaviour
{

    [SerializeField] Image diary;
    private bool isOpen = false;
    //[SerializeField] LevelManager levelManagerScript1;
    //[SerializeField] LevelManager levelManagerScript2;
    [SerializeField] bool isActive1;
    [SerializeField] bool isActive2;

    //[SerializeField] Canvas Panel_1;
    //[SerializeField] Canvas Panel_2;
    public Sprite[] pages;
    
    public Sprite[] swapPagesArr;
    public int currentIndex = 0;
    public int previousIndex;
    public Image displayingImage;

    private void Start()
    {
        UpdateSprite();
        
       //diary = GameObject.FindGameObjectWithTag("diary");
       //isActive1 = levelManagerScript1.isActive;
       //Debug.Log(isActive1);
       //isActive2 = levelManagerScript1.isActive;
       diary.gameObject.SetActive(false);

    }

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

    public void NextSprite()
    {
        currentIndex = (currentIndex + 1) % pages.Length;
        UpdateSprite();
    }

    public void PreviousSprite()
    {
        currentIndex = (currentIndex - 1 + pages.Length) % pages.Length;
        UpdateSprite();
    }

    private void UpdateSprite()
    {
        displayingImage.sprite = pages[currentIndex];
    }

    public void swapPage()
    {
        pages[currentIndex] = swapPagesArr[currentIndex];
    }


    void OpenDiary()
    {
        diary.gameObject.SetActive(true);
        isOpen = true;
        previousIndex = currentIndex; //save the index
        currentIndex = 0;
        Time.timeScale = 0f;
        UpdateSprite();

    }

    void CloseDiary()
    {
        diary.gameObject.SetActive(false);
        isOpen = false;
        currentIndex = previousIndex; //go back to the index
        Time.timeScale = 1f;

    }

    public void SwapPages()
    {

        pages[currentIndex] = swapPagesArr[currentIndex];
        currentIndex++;
        Debug.Log("Function called");
   

    }

  

}
