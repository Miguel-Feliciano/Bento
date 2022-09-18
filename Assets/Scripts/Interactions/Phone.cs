using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour, IInteractable
{
    public Dialogue dialogue;
    private ObjectiveManager objectiveManager;
    private Objective objective;

    private void Start()
    {
        objective = GetComponent<Objective>();
        objectiveManager = FindObjectOfType<ObjectiveManager>();
    }

    public string GetDescription()
    {
        return "Atender...";
    }

    public void Interact()
    {
        Time.timeScale = 0;
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        GameObject.Find("Telefone").GetComponent<Outline>().enabled = false;
        objective.ObjectiveCompleted = true;
        objectiveManager.VerifyObjective();
        Destroy(this);
    }
}
