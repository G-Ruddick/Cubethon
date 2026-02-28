using UnityEngine;

public class Player_collision : MonoBehaviour {

    public Player_movement playerMovement;

    void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Obsticle")
        {
            playerMovement.enabled = false;

            Object.FindFirstObjectByType<Player_movement>().Player_rb.AddTorque(Random.Range(-20000,20000),Random.Range(-20000,20000),Random.Range(-20000,20000));
            Object.FindFirstObjectByType<Player_movement>().Player_rb.AddForce(0,Random.Range(7,15),0 , ForceMode.VelocityChange);
            
            Object.FindFirstObjectByType<GameManager>().gameOver();
        }
    }
}
