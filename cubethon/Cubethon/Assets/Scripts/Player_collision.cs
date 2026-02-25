using UnityEngine;

public class Player_collision : MonoBehaviour {

    public Player_movement playerMovement;

    void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Obsticle")
        {
            playerMovement.enabled = false;
        }
    }
}
