using UnityEngine;

public class Obsticle : MonoBehaviour {
    public float speed = 2f;
    public float minHeight = 5f;
    public float maxHeight = 12f;
    public float minWidth = -6.5f;
    public float maxWidth = 6.5f;

    public IManueverBehavior obsticleBehavior;

    public void ApplyStrategy(IManueverBehavior strategy) {
        strategy.Maneuver(this);
    }

    private void Start() {
        obsticleBehavior = GetComponent<IManueverBehavior>();
        ApplyStrategy(obsticleBehavior);
    }
}
