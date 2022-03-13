using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideCheckPoint : MonoBehaviour
{
    public GameObject lastCheckPoint;
    public GameObject[] enemies1;
    public GameObject[] enemies2;
    public GameObject[] enemies3;

    
    private void OnTriggerEnter(Collider Player)
    {

        if (Player.gameObject.tag == "Player")
        {
            lastCheckPoint.SetActive(false);
        }
        if(lastCheckPoint.activeInHierarchy == false)
        {
            foreach(GameObject go in enemies1)
            {
                go.SetActive(false);
            }
            foreach (GameObject go in enemies2)
            {
                go.SetActive(false);
            }
            foreach (GameObject go in enemies3)
            {
                go.SetActive(false);
            }
            
        }
    }
        
}
