using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : Subject {
    public GameManager gameManager;
    private LevelCompleteController levelCompleteController;

    private void Awake() {
        if (!levelCompleteController) {
            levelCompleteController = gameObject.AddComponent<LevelCompleteController>();
        }
    }

    private void OnEnable() {
        if (levelCompleteController) {
            Attach(levelCompleteController);
        }
    }

    private void OnDisable() {
        if (levelCompleteController) {
            Detach(levelCompleteController);
        }
    }

    void OnTriggerEnter() {
        if (!gameManager.playerDead) {
            NotifyObservers();
            gameManager.gameWin();
        }
    }
}
