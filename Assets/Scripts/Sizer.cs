using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sizer : MonoBehaviour
{
    [Header("Oscillation Settings")]
    [Tooltip("Set max-min size multiplier of the object.")]
    public Vector2 targetSize = new Vector2(2f, 2f);
        
    [Tooltip("Set the speed of the size change.")]
    public float speed = 1;


    private Vector3 originalSize;
    private float time = 0f;
    private bool isGrowing = true;

    void Start()
    {
        originalSize = transform.localScale;
    }

    void Update()
    {
        time += Time.deltaTime * speed;

        if (isGrowing)
        {
            transform.localScale = Vector3.Lerp(originalSize, targetSize, time);
        }
        else
        {
            transform.localScale = Vector3.Lerp(targetSize, originalSize, time);
        }

        if (time >= 1f)
        {
            isGrowing = !isGrowing;
            time = time - (int)time;
        }
    }
}
