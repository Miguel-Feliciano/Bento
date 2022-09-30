using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShovelSave : MonoBehaviour, IInteractable
{
    public GameObject shovelSaved;
    public GameObject pitchfork;

    public string GetDescription()
    {
        return "Arrumar Pá";
    }

    public void Interact()
    {
        Destroy(GameObject.Find("shovel low saving"));
        shovelSaved.SetActive(true);
        Destroy(GameObject.Find("pitchfork low fake"));
        pitchfork.SetActive(true);
    }
}
