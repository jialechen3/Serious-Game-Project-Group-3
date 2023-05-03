using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coins : MonoBehaviour
{
    
    [SerializeField] GameObject controller;
    //Find healthBar
    [SerializeField] private HealthBar healthBar;

    [SerializeField] AudioSource audio;

    [SerializeField] public int coinNumbers;
    [SerializeField] public TextMeshProUGUI coinUI;

    // Start is called before the first frame update
    void Start()
    {
        //coinNumbers = PersistentData.Instance.GetCoin();
        GameObject.Find("CoinNumber").GetComponent<TextMeshProUGUI>().SetText(coinNumbers.ToString());
        if (controller == null)
        {
            controller = GameObject.FindGameObjectWithTag("GameController");
        }
        if (audio == null)
            audio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addCoin()
    {
        coinNumbers++;
        //PersistentData.Instance.SetCoin(coinNumbers);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {       
        healthBar.Increase();
        addCoin();
        AudioSource.PlayClipAtPoint(audio.clip, transform.position);
        //audio.Play();
        Destroy(gameObject);
        
        
    }
}