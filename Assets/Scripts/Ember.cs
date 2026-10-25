using UnityEngine;

public class Ember : MonoBehaviour
{
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