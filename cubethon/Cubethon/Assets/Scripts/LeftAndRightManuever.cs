using UnityEngine;
using System.Collections;

public class LeftAndRightManuever : MonoBehaviour, IManueverBehavior {
    public void Maneuver(Obsticle obsticle) {
        StartCoroutine(Weave(obsticle));
    }

    IEnumerator Weave(Obsticle obsticle) {
        float time;
        bool isReverse = false;
        float speed = obsticle.speed;

        Vector3 startPosition = obsticle.transform.position;
        Vector3 endPosition = startPosition;
        endPosition.x = startPosition.x == 6.5f ? obsticle.minWidth : obsticle.maxWidth;

        while (true) {
            time = 0;
            Vector3 start = obsticle.transform.position;
            Vector3 end = isReverse ? startPosition : endPosition;
            
            while (time < speed) {
                obsticle.transform.position = Vector3.Lerp(start, end, time / speed);
                time += Time.deltaTime;
                yield return null;
            }

            yield return new WaitForSeconds(0.25f);
            
            isReverse = !isReverse;
        }
    }
}
