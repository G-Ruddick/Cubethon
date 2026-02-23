using UnityEngine;

public class Player_movement : MonoBehaviour {
    public Rigidbody Player_rb;

    public float forwardSpeed;
    public float sideSpeed;
    public float getSideInput;

    void Start() {
        forwardSpeed = 1000f;
        sideSpeed = 50f;
    }

    void Update() {
        getSideInput = Input.GetAxis("Horizontal") * sideSpeed;
    }

    void FixedUpdate() {
        // forward speed
        Player_rb.AddForce(Vector3.forward * forwardSpeed * Time.deltaTime);

        // sideways input check
        Player_rb.AddForce(Vector3.right * getSideInput * Time.deltaTime, ForceMode.Impulse);
    }
}
