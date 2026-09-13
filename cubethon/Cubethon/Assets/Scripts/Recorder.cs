using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Recorder : MonoBehaviour{
    public static bool isRecording;
    public static bool isReplaying;
    private float replayTime;
    private float recordTime;

    public GameObject player;

    public static SortedList<float, RecordedInput> recordedInputs = new SortedList<float, RecordedInput>();

    private void Awake() {
    }

    private void FixedUpdate() {
        if (isRecording) {
            recordTime += Time.fixedDeltaTime;
            recordedInputs.Add(recordTime, new RecordedInput(player.transform.position, player.transform.rotation));
        }
        
        if (isReplaying) {
            player.GetComponent<Player_movement>().enabled = false;
            player.GetComponent<Player_collision>().enabled = false;

            replayTime += Time.fixedDeltaTime;
            
            if (recordedInputs.Any()) {
                if (Mathf.Approximately(replayTime, recordedInputs.Keys[0])) {
                    player.transform.position = recordedInputs.Values[0].position;
                    player.transform.rotation = recordedInputs.Values[0].rotation;
                    recordedInputs.RemoveAt(0);
                }
            }

            else {
                isReplaying = false;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else {
            player.GetComponent<Player_movement>().enabled = true;
            player.GetComponent<Player_collision>().enabled = true;
        }
    }

    public void Record() {
        if (!isReplaying) {
            recordedInputs.Clear();

            Debug.Log("Recording");
            recordTime = 0;
            isRecording = !isRecording;
        }
    }

    public void Replay() {
        isRecording = false;
        Debug.Log("Replaying");
        replayTime = 0;
        isReplaying = !isReplaying;

        if (recordedInputs.Count <= 0) {
            recordedInputs.Reverse();
            return;
        }

        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

[System.Serializable]
public struct RecordedInput {
    public Vector3 position;
    public Quaternion rotation;

    public RecordedInput(Vector3 position, Quaternion rotation) {
        this.position = position;
        this.rotation = rotation;
    }
}
