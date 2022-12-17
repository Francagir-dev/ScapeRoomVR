using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyColl : MonoBehaviour
{
    public GameObject Ghostkey;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody.gameObject.CompareTag("Player")) //Key collides with player
        {
            GameManager.instance.hasKey = true;
            Ghostkey.SetActive(true);
        } 
        else if (collision.rigidbody.CompareTag("Lock")) {
            if (GameManager.instance.hasKey) {
                Ghostkey.SetActive(false);
                GameManager.instance.door.isKinematic = true;
                collision.gameObject.SetActive(true);
            }
          
        }
       
    }
}
