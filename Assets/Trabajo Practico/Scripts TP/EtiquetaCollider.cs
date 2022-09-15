using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EtiquetaCollider : MonoBehaviour
{
    int etiquetasPegadas = 0;
    public Text txt_etiquetasPegadas;
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
        if (other.gameObject.CompareTag("Etiqueta"))
        {
            etiquetasPegadas = etiquetasPegadas + 1;
        }
        Debug.Log("La cantidad de etiquetas pegadas es de " + etiquetasPegadas);
    }
}
