using UnityEngine;

public class LevelCompleteController : Observer {
    private Finish finish;

    public override void Notify(Subject subject) {
        if (!finish) {
            finish = subject.GetComponent<Finish>();
        }

        if (finish) {
            GameObject.Find("/Player").GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
