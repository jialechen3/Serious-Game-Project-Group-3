using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    
    [SerializeField] GameObject controller;
    //Find healthBar
    [SerializeField] private HealthBar healthBar;

    [SerializeField] AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
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

    private void OnTriggerEnter2D(Collider2D collision)
    {       
        healthBar.Increase();
        AudioSource.PlayClipAtPoint(audio.clip, transform.position);
        //audio.Play();
        Destroy(gameObject);
        
        
    }
}