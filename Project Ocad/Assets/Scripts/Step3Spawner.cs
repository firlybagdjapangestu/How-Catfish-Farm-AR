using UnityEngine;

public class Step3Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public int numberOfObjects = 10;

    void Start()
    {
        SpawnObjects();
    }

    void SpawnObjects()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            GameObject spawnedObject = Instantiate(objectToSpawn, transform.position, Quaternion.identity);
            spawnedObject.transform.parent = transform;
            spawnedObject.transform.position = transform.position; // Ensure the spawned object is at the same position as this GameObject
        }
    }
}
