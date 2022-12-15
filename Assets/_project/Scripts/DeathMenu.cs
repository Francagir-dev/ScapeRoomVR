using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMenu : MonoBehaviour
{
    public Vector3 initialPosition =  new Vector3(0f, 1f, -1.08500004f);
    [SerializeField]private GameObject characterScapeRoom;
    public void ResetGame() {
        characterScapeRoom.transform.position = initialPosition;
    }
    public void QuitGame() {
        Application.Quit();
    }
}

