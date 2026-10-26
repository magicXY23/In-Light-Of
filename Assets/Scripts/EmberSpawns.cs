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

        Vector2 randomPos = new Vector2(Random.Range(halfWidth*-1f + 2f, halfWidth - 2f), Random.Range(halfHeight*-1f + 2f, halfHeight - 2f));
        Instantiate(emberPrefab, randomPos, Quaternion.identity);
    }    
}