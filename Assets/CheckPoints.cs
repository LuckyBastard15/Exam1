using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoints : MonoBehaviour
{
    public Transform checkPoint;
    public GameObject player;

    
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    private void OnTriggerEnter(Collider Player)
    {
        if(Player.gameObject.tag == "Player")
        {
            player.transform.position = checkPoint.position;
            // player.transform.rotation = checkPoint.rotation;
            
        }
        
    }
}
