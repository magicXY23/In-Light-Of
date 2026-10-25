using UnityEngine;

public class EmberSpawns : MonoBehaviour
{
    public GameObject emberPrefab;
    public float spawnInterval = 2f;
    public float minX = -25f, maxX = 25f;
    public float minY = -25f, maxY = 25f;

    void Start()
    {
        InvokeRepeating("SpawnEmber", 1f, spawnInterval);
    }

    void SpawnEmber()
    {
        Vector2 randomPos = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        Instantiate(emberPrefab, randomPos, Quaternion.identity);
    }    
}
