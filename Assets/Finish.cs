using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject[] lastEnemies;
    
    private void Start()
    {
        
    }
    private void OnTriggerEnter(Collider Player)
    {
        foreach(GameObject go in lastEnemies)
        {
            go.SetActive(false);
            
        }
        
    }
    
}
