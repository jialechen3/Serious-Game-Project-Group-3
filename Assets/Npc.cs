using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    public Spawner spawner;
    public bool collect = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        
        
        collect = true;
        
        spawner.SpawnObject();
        //if (other.gameObject.CompareTag("Player")) {
            
                
        //}
    }
}
