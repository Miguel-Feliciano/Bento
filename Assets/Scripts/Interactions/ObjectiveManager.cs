using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
    private void Start()
    {
        GameObject.Find("shovel low").SetActive(false);
        GameObject.Find("shovel low saving").SetActive(false);
        GameObject.Find("shovel low saved").SetActive(false);
        GameObject.Find("pitchfork low").SetActive(false);
    }
}
