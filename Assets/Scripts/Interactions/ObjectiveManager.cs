using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
    private void Start()
    {
        GameObject.Find("Pa").SetActive(false);
    }
}
