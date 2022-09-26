using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour, IInteractable
{
    public Dialogue dialogue;
    public GameObject shovel;

    public string GetDescription()
    {
        return "Atender...";
    }

    public void Interact()
    {
        Time.timeScale = 0;
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        GameObject.Find("Telefone").GetComponent<Outline>().enabled = false;
        Destroy(GameObject.Find("PaFalsa"));
        shovel.SetActive(true);
        Destroy(this);
    }
}
