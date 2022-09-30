using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitchforkSave : MonoBehaviour, IInteractable
{
    public GameObject pitchforkSaved;
    public GameObject exitDoor;
    
    public string GetDescription()
    {
        return "Guardar forcado";
    }

    public void Interact()
    {
        Destroy(GameObject.Find("pitchfork low saving"));
        pitchforkSaved.SetActive(true);
        Destroy(GameObject.Find("door fake"));
        exitDoor.SetActive(true);
    }
}
