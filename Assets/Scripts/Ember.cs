using UnityEngine;

public class Ember : MonoBehaviour
{
    private SpriteRenderer sr;
    private float timer = 0f;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 3f)
        {
            Color rgba = sr.color;
            rgba.a = 1 - (timer - 3f)/2f;
            sr.color = rgba;
        }
        if (timer >= 5f)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Campfire campfire = FindAnyObjectByType<Campfire>();
            campfire.AddFuel(25f);
            Destroy(gameObject);
        }
    }
}