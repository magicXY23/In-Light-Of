using UnityEngine;

public class EmberSpawns : MonoBehaviour
{
    public GameObject emberPrefab;
    public float spawnInterval = 3f;

    void Start()
    {
        InvokeRepeating("SpawnEmber", 1f, spawnInterval);
    }

    void SpawnEmber()
    {
        float camHeight = Camera.main.orthographicSize*2f;
        float camWidth = camHeight*Camera.main.aspect;

        Vector2 randomPos = new Vector2(Random.Range(camWidth*-1f + 2f, camWidth - 2f), Random.Range(camHeight*-1f + 2f, camHeight - 2f));
        Instantiate(emberPrefab, randomPos, Quaternion.identity);
    }    
}
