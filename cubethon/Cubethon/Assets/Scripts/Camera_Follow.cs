using UnityEngine;

public class Camera_Follow : MonoBehaviour {
    public Transform playerLocation;
    public Vector3 cameraOffset;

    void Update() {
        transform.position = playerLocation.position + cameraOffset;
    }
}
