using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [Header("Oscillation Settings")]
    [Tooltip("Set maximum move distance from the object origin.")]
    public float distance = 3f;

    [Tooltip("Set the speed of the movement.")]
    public float speed = 2f;

    [Tooltip("Enables - Move up-down. Disabled - Move left-right.")]
    public bool moveVertically = true;

    private Vector3 startPosition;
    private float time;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        time += Time.deltaTime * speed;

        float oscillation = Mathf.Sin(time) * distance;

        if (moveVertically)
        {
            transform.position = new Vector3(startPosition.x, startPosition.y + oscillation, startPosition.z);
        }
        else
        {
            transform.position = new Vector3(startPosition.x + oscillation, startPosition.y, startPosition.z);
        }
    }
}
