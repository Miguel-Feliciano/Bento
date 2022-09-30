using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoor : MonoBehaviour, IInteractable
{
    public string GetDescription()
    {
        return "Sair";
    }

    public void Interact()
    {
        SceneManager.LoadScene(0);
    }
}
