using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMenu : MonoBehaviour
{
    public Vector3 initialPosition =  new Vector3(2.5f, 1, -3.6f);

    [SerializeField]private GameObject characterScapeRoom;
    public void ResetGame() {
        characterScapeRoom.transform.position = initialPosition; //Asignamos posicion inicial
        GameManager.instance.deathMenu.SetActive(false); //Desactivamos el menu
        GameManager.instance.timer = 300;
        GameManager.instance.timerON = true;//reseteamos tiempo
        Time.timeScale = 1f;
        GameManager.instance.door.gameObject.transform.rotation = Quaternion.Euler(0f,0f,0f); //asignamos rotacion de puerta (por si la hubiesemos abierto)
    }
    public void QuitGame() {
        Application.Quit(1);//salimos del juego
    }
}

