using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class computerCollider : MonoBehaviour
{
    [SerializeField] GameObject UIComputer;
    public Text txt_etiquetasPegadas;
    int etiquetasPegadas;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("monitor"))
        {
            UIComputer.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            
        }

        if (other.gameObject.CompareTag("Etiqueta"))
        {
            etiquetasPegadas = etiquetasPegadas + 1;
            txt_etiquetasPegadas.text = etiquetasPegadas.ToString;
        }
        Debug.Log("La cantidad de etiquetas pegadas es de " + etiquetasPegadas);
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("monitor"))
        {
            UIComputer.SetActive(false);
        }
    }
}
