using UnityEngine;

public class DamageController : Observer {
    private Player_collision playerCollision;
    private new Camera camera;

    public override void Notify(Subject subject) {
        if (!playerCollision) {
            playerCollision = subject.GetComponent<Player_collision>();
        }

        if (playerCollision) {
            // Debug.LogError("Damaged");
            camera = FindAnyObjectByType<Camera>();
            camera.backgroundColor = new Color(1f, 0, 0);
        }
    }
}
