using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Complete : MonoBehaviour {
    void loadNextLevel() {
        SceneManager.LoadScene("Level_02");
    }
}
