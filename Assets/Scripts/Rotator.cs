using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [Header("Rotation Settings")]
    [Tooltip("Set the speed of rotatio.")]
    public float rotationSpeed = 90f;

    [Tooltip("True - rotate clockwise, False - rotate anti clockwise.")]
    public bool clockwise = true;

    void Start()
    {

    }

    void Update()
    {
        float direction = clockwise ? -1f : 1f;
        transform.Rotate(0f, 0f, direction * rotationSpeed * Time.deltaTime);
    }
}
