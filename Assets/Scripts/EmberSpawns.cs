using System.Data;
using UnityEngine;

public class EmberSpawns : MonoBehaviour
{
    public GameObject emberPrefab;
    public float spawnInterval = 2f;

    void Start()
    {
        InvokeRepeating("SpawnEmber", 0f, spawnInterval);
    }

    void SpawnEmber()
    {
        float halfHeight = Camera.main.orthographicSize;
        float halfWidth = halfHeight*Camera.main.aspect;

        Vector3 randomPos = new Vector3(Random.Range(halfWidth*-1f + 2f, halfWidth - 2f), Random.Range(halfHeight*-1f + 2f, halfHeight - 2f), -1);
        Instantiate(emberPrefab, randomPos, Quaternion.identity);
    }
}