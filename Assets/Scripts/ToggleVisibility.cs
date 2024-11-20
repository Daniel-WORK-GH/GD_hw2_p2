using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleVisibility : MonoBehaviour
{
    [Header("Visibility Toggle Settings")]
    [Tooltip("The key to press for toggling.")]
    public InputAction toggleVisibilityAction;

    private Renderer objectRenderer;

    void Awake()
    {
        toggleVisibilityAction.Enable();
        objectRenderer = GetComponent<Renderer>();
    }

    void OnEnable()
    {
        toggleVisibilityAction.performed += ToggleObjectVisibility;
    }

    void OnDisable()
    {
        toggleVisibilityAction.performed -= ToggleObjectVisibility;
    }

    void ToggleObjectVisibility(InputAction.CallbackContext context)
    {
        if (objectRenderer != null)
        {
            objectRenderer.enabled = !objectRenderer.enabled;
        }
    }
}
