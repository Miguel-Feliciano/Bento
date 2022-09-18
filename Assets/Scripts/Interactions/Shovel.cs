using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shovel : MonoBehaviour, IInteractable
{
    private Objective objective;

    private void Start()
    {
        objective = GetComponent<Objective>();
    }

    public string GetDescription()
    {
        return "Agarrar Pá";
    }

    public void Interact()
    {
        objective.ObjectiveCompleted = true;
        Destroy(GameObject.Find("Pa"));
    }
}
