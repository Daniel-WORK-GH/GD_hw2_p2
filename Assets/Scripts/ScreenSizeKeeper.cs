using UnityEngine;

public class ScreenSizeKeeper : MonoBehaviour
{
    private float initialAspect;
    private float initialSize;

    void Start()
    {
        initialAspect = (float)Screen.width / Screen.height;

        initialSize= Camera.main.orthographicSize;
    }

    void Update()
    {
        if (Mathf.Abs(initialAspect - (float)Screen.width / Screen.height) > 0.01f)
        {
            AdjustCamera();
        }
    }

    private void AdjustCamera()
    {
        float currentAspect = (float)Screen.width / Screen.height;

        if (currentAspect > initialAspect)
        {
            // If the screen is wider than the initial aspect, increase the orthographic size
            Camera.main.orthographicSize = initialSize * (initialAspect / currentAspect);
        }
        else
        {
            // If the screen is taller or equal to the initial aspect, reset orthographic size
            Camera.main.orthographicSize = initialSize;
        }
    }
}
