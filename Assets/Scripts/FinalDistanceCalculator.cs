using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDistanceCalculator : MonoBehaviour
{
    private Vector3 initialPosition;
    private Vector3 currentPosition;
    private float finalDistance;
    
    private void Start()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
        currentPosition = transform.position;
        finalDistance = Vector3.Distance(initialPosition, currentPosition);
    }

    public float FinalDistance
    {
        get { return finalDistance; }
    }

}
