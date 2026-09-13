using UnityEngine;

public class Ground_Create : MonoBehaviour
{
    public Rigidbody Player_rb;
    public GameObject Ground;
    public int groundNumber = 1;
    public int objectNumber = 1;

    public GameObject[] objectTypes;

    void Update()
    {
        if (Player_rb.position.z > 300 * (groundNumber - 3)) {
            duplicateGround();
        }

        if (Player_rb.position.z > 30 * (objectNumber - 1)) {
            ObjectSpawn();
        }
    }

    void duplicateGround()
    {
        groundNumber++;
        GameObject GroundDuplicate = Instantiate(Ground, new Vector3(0,0, 300 * groundNumber) , new Quaternion(0,0,0,0));
        // Destroy(GroundDuplicate, 40f);
    }

    void ObjectSpawn() {
        GameObject Obstical = Instantiate(objectTypes[Random.Range(0, 5)], new Vector3(0, 0, 65 * objectNumber), new Quaternion(0,0,0,0));
        objectNumber++;
        // Destroy(Obstical, 80f);
    }
}
