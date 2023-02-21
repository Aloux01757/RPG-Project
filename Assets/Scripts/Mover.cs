using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; // Use this when using NavMeshAgent.

public class Mover : MonoBehaviour
{
    [SerializeField] Transform target;
    Ray lastRay; 

    void Update()
    {
        if(Input.GetMouseButtonDown(0)) // Check if the left mouse button was clicked.
        {
            lastRay = Camera.main.ScreenPointToRay(Input.mousePosition); //Cast a ray from the mouse position using the main camera.
        }
        Debug.DrawRay(lastRay.origin, lastRay.direction * 100); // Draw the ray for debugging purposes.
        GetComponent<NavMeshAgent>().destination = target.position;
    }
}
