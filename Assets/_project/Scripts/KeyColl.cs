using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyColl : MonoBehaviour
{
    public GameObject Ghostkey;
    [Header("HANDS VR")]
    public GameObject LeftHand;
    public GameObject RightHand;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) { //Triggereamos con el jugador (manos)
            GameManager.instance.hasKey = true; //asignamos que la tenemos
            if (!GameManager.instance.hasOpened)
                Ghostkey.SetActive(true);
            else
                Ghostkey.SetActive(false);
        }
        else if (other.gameObject.CompareTag("Lock"))
        {
            if (GameManager.instance.hasKey)
            {
                Ghostkey.SetActive(false);
                GameManager.instance.door.isKinematic = true; //cambiamos a collider para las bombas
                other.gameObject.SetActive(false);
                GameManager.instance.hasOpened = true;
                LeftHand.GetComponent<SphereCollider>().isTrigger = false; 
                RightHand.GetComponent<SphereCollider>().isTrigger = false; //cambiamos a collider para las bombas
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.instance.hasKey = false;
            Ghostkey.SetActive(false);
        }

        }
}
