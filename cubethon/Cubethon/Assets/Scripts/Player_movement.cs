using UnityEngine;

public class Player_movement : MonoBehaviour {
    public Rigidbody Player_rb;

    public float forwardSpeed;
    public float sideSpeed;
    public float getSideInput;

    void Start() {
        forwardSpeed = 60f;
        sideSpeed = 50f;
        Physics.gravity = new Vector3(0,-30f,0);
    }

    void Update() {
        getSideInput = Input.GetAxis("Horizontal") * sideSpeed;
    }

    void FixedUpdate() {
        // forward speed
        Player_rb.AddForce(Vector3.forward * forwardSpeed * Time.deltaTime, ForceMode.VelocityChange);

        // sideways input check
        Player_rb.AddForce(Vector3.right * getSideInput * Time.deltaTime, ForceMode.VelocityChange);

        if (Player_rb.position.y < -4f) {
            Player_rb.AddForce(Random.Range(-50f,50f),Random.Range(-50f,50f),Random.Range(-50f,50f), ForceMode.VelocityChange);
            Player_rb.AddTorque(Random.Range(-20000,20000),Random.Range(-20000,20000),Random.Range(-20000,20000));

            
            Object.FindFirstObjectByType<GameManager>().gameOver();
        }
    }
}
