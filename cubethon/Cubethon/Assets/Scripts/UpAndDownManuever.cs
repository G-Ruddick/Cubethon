using UnityEngine;
using System.Collections;

public class UpAndDownManuever : MonoBehaviour, IManueverBehavior {
    public void Maneuver(Obsticle obsticle) {
        StartCoroutine(Weave(obsticle));
    }

    IEnumerator Weave(Obsticle obsticle) {
        float time;
        bool isReverse = false;
        float speed = obsticle.speed;

        Vector3 startPosition = obsticle.transform.position;
        Vector3 endPosition = startPosition;
        endPosition.y = startPosition.y == 5f ? obsticle.maxHeight : obsticle.minHeight;

        while (true) {
            time = 0;
            Vector3 start = obsticle.transform.position;
            Vector3 end = isReverse ? startPosition : endPosition;
            
            while (time < speed) {
                obsticle.transform.position = Vector3.Lerp(start, end, time / (speed * 0.5f));
                time += Time.deltaTime;
                yield return null;
            }

            yield return new WaitForSeconds(0.1f);
            
            isReverse = !isReverse;
        }
    }
}
