using UnityEngine;

public class CatfishBehaviour : MonoBehaviour
{
    public Transform minX;
    public Transform maxX;
    public Transform minZ;
    public Transform maxZ;
    public float speed;
    public float scale;

    private Vector3 targetPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.localScale = new Vector3(scale, scale, scale);
        SetNewRandomTarget();
    }

    // Update is called once per frame
    void Update()
    {
        Patrol();
    }

    void Patrol()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        transform.forward = targetPosition - transform.position;

        if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
        {
            SetNewRandomTarget();
        }
    }

    void SetNewRandomTarget()
    {
        float randomX = Random.Range(minX.position.x, maxX.position.x);
        float randomZ = Random.Range(minZ.position.z, maxZ.position.z);
        targetPosition = new Vector3(randomX, transform.position.y, randomZ);
    }
}
