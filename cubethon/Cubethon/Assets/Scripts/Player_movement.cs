using UnityEngine;
using UnityEngine.UI;

public class Player_movement : Subject {
    public float forwardSpeed;
    public float sideSpeed;
    public float getSideInput;
    public bool slowDown;

    public Rigidbody Player_rb;
    public Button slowDownButton;

    private SlowDownController slowDownController;

    void Awake() {
        slowDownController = gameObject.AddComponent<SlowDownController>();
        slowDownButton = GameObject.Find("Slow Down Button").GetComponent<Button>();
        slowDownButton.onClick.AddListener(NotifyObservers);
    }

    private void OnEnable() {
        if (slowDownController) {
            Attach(slowDownController);
        }
    }

    private void OnDisable() {
        if (slowDownController) {
            Detach(slowDownController);
        }
    }

    void Start() {
        forwardSpeed = 60f;
        sideSpeed = 50f;
        slowDown = false;
        Physics.gravity = new Vector3(0,-30f,0);
    }

    void Update() {
        // Debug.Log(forwardSpeed);
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
