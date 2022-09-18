using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
    [SerializeField] private GameObject[] objectivesGameObject;
    [SerializeField] private List<Objective> objectives;


    [SerializeField] private GameObject[] interactivesObjects;

    [SerializeField]
    private int number;


    

    private void Start()
    {
        number = 1;
        objectivesGameObject = GameObject.FindGameObjectsWithTag("Objective");

        foreach(var m in objectivesGameObject)
        {
            objectives.Add(m.GetComponent<Objective>());
        }

        foreach(var x in objectives)
        {
            x.gameObject.SetActive(false);

            if (number == x.ObjectiveNumber)
            {
                print(x.gameObject.name);
                x.gameObject.SetActive(true);
            }


        }

    }

    private void Update()
    {
        foreach (var x in objectives)
        {

            if (x.ObjectiveNumber == number)
                  x.gameObject.SetActive(true);

        }
    }


    public void VerifyObjective()
    {
        foreach(var x in objectives)
        {
           
            if (x.ObjectiveNumber == number)
                if (x.ObjectiveCompleted == true)
                    number++;
               

            if (x.ObjectiveNumber == number)
                if (x.ObjectiveCompleted)
                    if (x.gameObject.activeSelf == false)
                        x.gameObject.SetActive(true);
            
        }
    }


   
}
