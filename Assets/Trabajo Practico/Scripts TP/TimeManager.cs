using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public Text txt_Timetime;
    public TextMeshProUGUI EstadoDeJuego;
    public GameObject EstadoJugador;
    float time;
    float timeMax = 300;
    public int GameTime;
    bool isAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = Time.time;
        txt_Timetime.text = Mathf.Floor(time).ToString();

        if (time == timeMax)
        {
            EstadoDeJuego.text = "Perdiste!";
            EstadoJugador.SetActive(true);
        }

    }
}
