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
        GameObject.Find("phone").GetComponent<Outline>().enabled = false;
        Destroy(GameObject.Find("shovel low fake"));
        shovel.SetActive(true);
        Destroy(this);
    }
}
