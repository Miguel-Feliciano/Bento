using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShovelSave : MonoBehaviour, IInteractable
{
    public GameObject shovelSaved;

    public string GetDescription()
    {
        return "Arrumar Pá";
    }

    public void Interact()
    {
        Destroy(GameObject.Find("PaGuardar"));
        shovelSaved.SetActive(true);
    }
}
