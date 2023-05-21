using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class School : MonoBehaviour
{
    public GameObject school;
    public GameObject donation;
    BoxCollider2D _school;

    // Start is called before the first frame update
    void Start()
    {
        _school = gameObject.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (school.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                existPic2();
            }
        }

        if (donation.active == true)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                existPic1();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If we triggerd the player enable playerdeteced and show indicator
        if (collision.tag == "Player")
        {
            inDonation();
            
        }
    }
    public void inDonation()
    {
        donation.SetActive(true);
    }
    public void existPic1()
    {
        donation.SetActive(false);
        school.SetActive(true);
    }
    public void existPic2()
    {
        school.SetActive(false);
        _school.enabled = !_school.enabled;
    }
}
