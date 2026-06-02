using UnityEngine;

public class PinchZoom : MonoBehaviour
{
    [Header("Camera Zoom Settings")]
    public float zoomSpeed = 0.05f;
    public float minFOV = 15f;
    public float maxFOV = 90f;
    
    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        // Listen strictly for two fingers on the touch screen
        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            // Calculate where the fingers were in the previous frame
            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            // Calculate the magnitude of distance between fingers
            float prevMagnitude = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float currentMagnitude = (touchZero.position - touchOne.position).magnitude;

            // Find the delta (positive = pinching out, negative = pinching in)
            float difference = currentMagnitude - prevMagnitude;

            // Dynamically alter the camera's Field of View
            cam.fieldOfView -= difference * zoomSpeed;
            
            // Clamp the math so the screen doesn't invert or zoom infinitely
            cam.fieldOfView = Mathf.Clamp(cam.fieldOfView, minFOV, maxFOV);
        }
    }
}
