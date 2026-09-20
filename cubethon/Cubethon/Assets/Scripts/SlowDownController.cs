using UnityEngine;
using TMPro;

public class SlowDownController : Observer {
    private Player_movement playerMovement;

    public override void Notify(Subject subject) {
        if (!playerMovement) {
            playerMovement = subject.GetComponent<Player_movement>();
        }

        if (playerMovement) {
            if (playerMovement.slowDown) {
                playerMovement.forwardSpeed *= 2;
                playerMovement.slowDownButton.GetComponentInChildren<TMP_Text>().text = "Slow Down";
            }

            else {
                playerMovement.forwardSpeed /= 2;
                playerMovement.slowDownButton.GetComponentInChildren<TMP_Text>().text = "Speed up";
            }
        }

        playerMovement.slowDown = !playerMovement.slowDown;
    }
}
