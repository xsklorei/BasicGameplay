using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    //destroy what is touched 
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
