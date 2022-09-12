using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] GameObject UIElements;
    [SerializeField] TextMeshProUGUI dialogueTxt;
    [SerializeField] string [] NPCDialogue;
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
        if(other.gameObject.GetComponent<NPCDialogue>().data)
        {
            UIElements.SetActive(true);
            NPCDialogue = other.gameObject.GetComponent<NPCDialogue>().data.dialogueLines;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("NPC"))
        {
            UIElements.SetActive(false);
        }
    }

    public void ShowNextDialogueLine()
    {
        //dialogueTxt.text = 
    }
}
