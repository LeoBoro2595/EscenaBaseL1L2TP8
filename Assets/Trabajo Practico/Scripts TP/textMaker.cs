using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textMaker : MonoBehaviour
{

    public GameObject textSpawnPoint;
    public GameObject textPrefab;
    GameObject clonText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            clonText = Instantiate(textPrefab);
            clonText.transform.position = textSpawnPoint.transform.position;
            clonText.transform.Rotate(0, 90, 0);
        }
    }
}
