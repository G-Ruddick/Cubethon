using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Complete1 : MonoBehaviour {
    void loadNextLevel() {
        SceneManager.LoadScene("Level_02");
    }
}
