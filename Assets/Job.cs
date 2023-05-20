using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Job : MonoBehaviour
{
    public GameObject job;
    BoxCollider2D _job;

    // Start is called before the first frame update
    void Start()
    {
        _job = gameObject.GetComponent<BoxCollider2D>();
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
            atJob();

        }
    }
    public void atJob()
    {
        job.SetActive(true);
    }
    public void existPic1()
    {
        job.SetActive(false);
        _job.enabled = !_job.enabled;
    }
}
