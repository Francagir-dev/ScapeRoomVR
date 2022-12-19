using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bomb : MonoBehaviour
{
     [SerializeField] private string bombColor;   

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody.gameObject.CompareTag("Player")) {

            if (GameManager.instance.CheckColor(bombColor)) {
                gameObject.SetActive(false);
                GameManager.instance.bombsDeactivated.Add(this.gameObject);
                if (bombColor.Equals("amarillo")) { }//WIN
            } 
            else if(!GameManager.instance.CheckColor(bombColor)) {
                foreach (GameObject bomba in GameManager.instance.bombsDeactivated) {
                    bomba.SetActive(true);                   
                }
            }       
        }
    }
       

}

