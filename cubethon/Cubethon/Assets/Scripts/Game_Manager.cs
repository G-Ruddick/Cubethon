using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Player_movement playerMovement;
    public GameObject completeLevelUI;

    public bool playerDead = false;

    void Start() {
        completeLevelUI.SetActive(false);
    }
    public void gameWin() {
        playerMovement.enabled = false;

        completeLevelUI.SetActive(true);
    }

    public void gameOver(){
        if (!playerDead) { 
            playerDead = true; 
            Invoke("Restart", 1.5f);
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
