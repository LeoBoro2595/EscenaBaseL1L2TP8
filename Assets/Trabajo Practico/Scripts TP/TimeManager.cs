using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public Text txt_Timetime;
    public Text EstadoDeJuego;
    public GameObject EstadoJugador;
    float time;
    public int GameTime;
    bool isAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        EstadoJugador.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time = Time.time;
        txt_Timetime.text = Mathf.Floor(time).ToString();

        if (time >= GameTime)
        {
            EstadoDeJuego.text = "Perdiste!";
            EstadoJugador.SetActive(true);
        }

    }
}
