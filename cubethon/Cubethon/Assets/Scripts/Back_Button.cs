using UnityEngine;
using UnityEngine.SceneManagement;

public class Back_Button : MonoBehaviour {
    public void ReturnToMenu() {
        SceneManager.LoadScene("Start Screen");
    }
}
