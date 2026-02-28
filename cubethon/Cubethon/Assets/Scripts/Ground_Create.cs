using UnityEngine;

public class Ground_Create : MonoBehaviour
{
    public Rigidbody Player_rb;
    public GameObject Ground;
    public int groundNumber = 1;

    void Start()
    {

    }

    void Update()
    {
        if (Player_rb.position.z > 300 * (groundNumber - 3)) {
            duplicateGround();
        }
    }

    void duplicateGround()
    {
        groundNumber++;
        Vector3 spawnPosition = Ground.transform.position + (transform.forward * 300 * groundNumber);
        GameObject GroundDuplicate = Instantiate(Ground, spawnPosition , Quaternion.identity);
        Destroy(GroundDuplicate, 20f);
    }
}
