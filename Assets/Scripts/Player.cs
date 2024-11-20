using System;
using Unity.Android.Gradle.Manifest;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [Header("Player Settings")]
    [Tooltip("Player jump force.")]
    public float jumpForce = 20;

    [Tooltip("Player move speed.")]
    public float moveSpeed = 10;

    Rigidbody2D rb;

    public const float eps = 0.01f;// Epsilon for small movements

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.tag = "Player";
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            rb.position += Vector2.left * moveSpeed * Time.deltaTime;
	    }
        if(Input.GetKey(KeyCode.D))
        {
            rb.position += Vector2.right * moveSpeed * Time.deltaTime;
	    }
        if( Input.GetKeyDown(KeyCode.W) && Math.Abs(rb.linearVelocityY) <eps) 
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); 
        }
    }
}
