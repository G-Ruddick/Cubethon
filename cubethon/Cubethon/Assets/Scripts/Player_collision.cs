using UnityEngine;

public class Player_collision : Subject {
    public Player_movement playerMovement;

    private DamageController damageController;

    private void Awake() {
        if (!damageController) {
            damageController = gameObject.AddComponent<DamageController>();
        }
    }

    private void OnEnable() {
        if (damageController) {
            Attach(damageController);
        }
    }

    private void OnDisable() {
        if (damageController) {
            Detach(damageController);
        }
    }

    void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Obsticle") {
            NotifyObservers();

            playerMovement.enabled = false;

            Object.FindFirstObjectByType<Player_movement>().Player_rb.AddTorque(Random.Range(-20000,20000),Random.Range(-20000,20000),Random.Range(-20000,20000));
            Object.FindFirstObjectByType<Player_movement>().Player_rb.AddForce(0,Random.Range(7,15),0 , ForceMode.VelocityChange);
            
            Object.FindFirstObjectByType<GameManager>().gameOver();
        }
    }
}
