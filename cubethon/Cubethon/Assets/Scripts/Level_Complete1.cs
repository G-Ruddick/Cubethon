using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Complete1 : MonoBehaviour {
    public void loadNextLevel() {
        SceneManager.LoadScene("Level_endless");
    }
}
