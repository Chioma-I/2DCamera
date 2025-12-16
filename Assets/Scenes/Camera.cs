using UnityEngine;

public class Camera : MonoBehaviour
{
    // da object we want the camera to follow (usually the player)
    public Transform target;

    //  How far the camera sits relative to the player
    // In 2D, (0, 0, -10) keeps it behind the player on the Z axis
    public Vector3 offset = new Vector3(0f, 0f, -10f);

    //  how quickly the camera moves toward the target position
    // higher = snappier, lower = floatier
    public float smoothSpeed = 5f;

    // Called after all Update() calls each frame
    // Perfect for cameras, so it moves *after* the player does
    void LateUpdate()
    {
        // ❌ if no target is assigned, do nothing
        if (target == null)
            return;

        // The position we *want* the camera to move toward
        Vector3 desiredPosition = target.position + offset;

        // Smoothly move from current position → desired position
        Vector3 smoothedPosition = Vector3.Lerp(
            transform.position,       // where the camera is now
            desiredPosition,          // where we want it to go
            smoothSpeed * Time.deltaTime // speed factor (frame-rate independent)
        );

        // apply the new smoothed position
        transform.position = smoothedPosition;

        // We don’t rotate the camera in 2D
        // so no LookAt() or rotation changes needed
    }
}
