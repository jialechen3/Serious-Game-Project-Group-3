using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Npc : MonoBehaviour
{
    public Spawner spawner;
    public bool collect = false;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
            
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        collect = true; 
        spawner.SpawnObject();
    }
}

