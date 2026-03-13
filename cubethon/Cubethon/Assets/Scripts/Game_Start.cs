using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Start : MonoBehaviour {
    public void loadFirstLevel() {
        SceneManager.LoadScene("Level_01");
    }
}
