using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter() {
        if (!gameManager.playerDead) {
            gameManager.gameWin();
        }
    }
}
