using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Complete : MonoBehaviour {
    public void loadNextLevel() {
        SceneManager.LoadScene("Level_02");
    }
}
