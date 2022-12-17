using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("Timer")]
    public float timer = 300f; //5 min
    private bool timerON = true;
    public TextMeshProUGUI countdownTxt;//Texto contador

    [Header("Door puzzle")]
    public bool hasKey;
    public Rigidbody door;

    [Header("Bomb Puzzle")]
    List<string> colorOrder = new List<string>() { "verde", "azul", "amarillo" };
    List<string> colorOrderBackUp = new List<string>() { "verde", "azul", "amarillo" };

    [HideInInspector] public List<GameObject> bombsDeactivated = new List<GameObject>();

    [Header("UI")]
    public GameObject deathMenu;


    private void Awake()
    {
        if (instance != null && instance != this) Destroy(this);
        else instance = this;
    }


    // Update is called once per frame
    void Update()
    {
        if (timerON)
        {
            if (timer > 0.0f) 
            {
                timer -= Time.deltaTime;  //quitamos el tiempo desde el ultimo frame   
            }
            else
            {
                timer = 0f; //timer a 0, cuando vaya a ser menor
                timerON = false;//paramos el contador
                deathMenu.SetActive(true);
            }
            timerTXT(timer);//asignamos el tiempo
        }
    }

    /// <summary>
    /// Calculate Minutes and Seconds from timer, and writes it in HUD
    /// </summary>
    /// <param name="time">Time remaining</param>
    /// <returns>Time remaining as String to show it on screen </returns>
    public void timerTXT(float time) {
        //calculamos minutos y segundos
        float minutes = time / 60; 
        float seconds = time % 60;

        string textCounter = string.Format("{0:00}:{0:00}", minutes, seconds); //formateamos el texto para que el contador se noten los minutos y segundos
        countdownTxt.text = textCounter;
       
        Debug.Log(textCounter);

    }
    /// <summary>
    /// Check color sequence
    /// </summary>
    /// <param name="color"></param>
    /// <returns></returns>
    public bool CheckColor(string color) {
        //Comprobamos que el color del cable sea el primero en la lista
        if (color.Equals(colorOrder[0]))
        {
            colorOrder.Remove(color);//Eliminamos para quitar de lista
            return true;
        }
        else { //Si fallamos reseteamos
            colorOrder = colorOrderBackUp;
            bombsDeactivated.Clear();
            return false;
        }
       
    }



}
