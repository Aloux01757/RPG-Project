using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; // Use this when using NavMeshAgent.

public class Mover : MonoBehaviour
{
    [SerializeField] Transform target;

    void Update()
    {
        if(Input.GetMouseButtonDown(0)) // Check if the left mouse button was clicked.
        {
            MoveToCursor();
        }

    }

    private void MoveToCursor()
    {
        // Cast a ray from the main camera towards the position of the mouse on the screen
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
        // Variable to store information about the object that the ray hit
        RaycastHit hit;
        // Check if the ray hits any object with a collider in the scene, and store information about the hit in the 'hit' variable
        bool hasHit = Physics.Raycast(ray,out hit);

        if(hasHit)
        {
            GetComponent<NavMeshAgent>().destination = hit.point;
        }

    }
}
