using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private float mouseSensitivity = 3.0f;
    [SerializeField] private Transform pivotPoint;
    [SerializeField] private float distanceFromPivot = 5f;

    private void Start()
    {
        // Do I need to calculate the center of the game object in the middle here? gameobject size?
        // I need to use the new input system with this
    }

    private void Update()
    {
    }

    private Vector3 CalculatePivotPoint(int size, float qubeSize) =>
        new Vector3(size * qubeSize / 2, size * qubeSize / 2, size * qubeSize / 2);
}