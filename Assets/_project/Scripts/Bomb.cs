using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Bomb : MonoBehaviour
{
     [SerializeField] private string bombColor;
    [SerializeField] private TextMeshProUGUI finalTXT;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody.gameObject.CompareTag("Player")) {

            if (GameManager.instance.CheckColor(bombColor)) {
                this.gameObject.SetActive(false);
                GameManager.instance.bombsDeactivated.Add(this.gameObject);//add this bomb
                if (bombColor.Equals("amarillo")) { //last color
                    GameManager.instance.deathMenu.SetActive(true);//activamos menu muerte
                    finalTXT.text = "You deactivated the bombs";//Cambiamos TXT
                }//WIN
            } 
            else if(!GameManager.instance.CheckColor(bombColor)) {
                foreach (GameObject bomba in GameManager.instance.bombsDeactivated) {
                    bomba.SetActive(true); //Reactivamos bombas
                }
            }       
        }
    }
}

