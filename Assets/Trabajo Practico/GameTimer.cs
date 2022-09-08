using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public Text timer;
    public Text EstadoDeJuego;
    float time;
    bool isAlive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsAlive)
        {
            timer = Time.time * 100;
            timer = Mathf.Floor(time) / 100;

            timer.text = "" + time.ToString();
        }



        if (time > GameTime)
        {
            isAlive = false;
            timer.text = timer.text;
            EstadoDeJuego.text = "Perdiste!";
        }
    }
}
