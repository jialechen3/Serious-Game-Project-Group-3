using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class School : MonoBehaviour
{
    public GameObject school;
    BoxCollider2D _school;

    // Start is called before the first frame update
    void Start()
    {
        _school = gameObject.GetComponent<BoxCollider2D>();
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
            inSchool();
            
        }
    }
    public void inSchool()
    {
        school.SetActive(true);
    }
    public void existPic1()
    {
        school.SetActive(false);
        _school.enabled = !_school.enabled;
    }
}
