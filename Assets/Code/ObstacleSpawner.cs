using System.Collections;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private float spawnInterval = 2f;
    [SerializeField] private float spawnRangeDown = -3f;
    [SerializeField] private float spawnRangeUp = 3f;
    [SerializeField] private GameObject obstaclePrefab;

    private IEnumerator Start()
    {
        while (true)
        {
            SpawnObstacle();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    private void SpawnObstacle()
    {
        float spawnY = Random.Range(spawnRangeDown, spawnRangeUp);
        Vector3 spawnPosition = new Vector3(transform.position.x, spawnY, 0);
        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
    }
}
