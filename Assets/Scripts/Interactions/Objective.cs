using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour
{
    [SerializeField]
    private int objectiveNumber;
    [SerializeField]
    private bool objectiveCompleted;
  
    // Properties
    public int ObjectiveNumber => objectiveNumber;
    public bool ObjectiveCompleted
    {
        get => objectiveCompleted;
        set => objectiveCompleted = value;
    }
}
