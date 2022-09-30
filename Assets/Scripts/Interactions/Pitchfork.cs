using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pitchfork : MonoBehaviour, IInteractable
{
    public string GetDescription()
    {
        return "Agarrar forcado";
    }

    public void Interact()
    {
        Destroy(GameObject.Find("pitchfork low"));
    }
}
