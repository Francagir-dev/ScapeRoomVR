using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyColl : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody.gameObject.CompareTag("Player")) {
            GameManager.instance.hasKey = true;
        } 
        else if (collision.rigidbody.CompareTag("Lock")) { 
        
        }
       
    }
}
