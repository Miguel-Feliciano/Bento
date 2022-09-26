using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
    private void Start()
    {
        GameObject.Find("Pa").SetActive(false);
        GameObject.Find("PaGuardar").SetActive(false);
        GameObject.Find("PaGuardada").SetActive(false);
    }
}
