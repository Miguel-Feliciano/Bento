using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shovel : MonoBehaviour, IInteractable
{
    public string GetDescription()
    {
        return "Agarrar Pá";
    }

    public void Interact()
    {
        Destroy(GameObject.Find("Pa"));
    }
}
