using UnityEngine;

public class Campfire : MonoBehaviour
{
    public float maxFireHealth = 300f;
    public float fireHealth = 50f;
    public float burnRate = 5f;

    void Update()
    {
        if(fireHealth > 0)
        {
            fireHealth -= burnRate*Time.deltaTime;
        }
        else
        {
            // game over
        }
    }
    
    public void AddFuel(float amount)
    {
        fireHealth += amount;
        if(fireHealth > maxFireHealth)
        {
            fireHealth = maxFireHealth;
        }
    }
}
