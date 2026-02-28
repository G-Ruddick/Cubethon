using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TMP_Text scoreText;

    // Update is called once per frame
    void Update()
    {
        if (!Object.FindFirstObjectByType<GameManager>().playerDead) {
            scoreText.text = player.position.z.ToString("0");
        }
    }
}
