using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCheckPoins : MonoBehaviour
{
    public GameObject checkPoint;
    
    private void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.tag == "Player") 
        {
            
            Destroy(checkPoint);
            Destroy(gameObject);
        }    
    }
}
