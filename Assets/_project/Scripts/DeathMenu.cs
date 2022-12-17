using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMenu : MonoBehaviour
{
    public Vector3 initialPosition =  new Vector3(2.5f, 1, -3.6f);

    [SerializeField]private GameObject characterScapeRoom;
    public void ResetGame() {
        characterScapeRoom.transform.position = initialPosition;
        GameManager.instance.deathMenu.SetActive(false);
        GameManager.instance.timer = 300;
    }
    public void QuitGame() {
        Application.Quit();
    }
}

