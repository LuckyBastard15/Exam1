using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObst : MonoBehaviour
{
     
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
