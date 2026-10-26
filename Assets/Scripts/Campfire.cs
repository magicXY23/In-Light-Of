using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Campfire : MonoBehaviour
{
    public float maxFireHealth = 300f;
    public float fireHealth = 50f;
    public float burnRate = 5f;
    public Light2D fireLight;
    public float maxFireLightRadius = 12f;

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
        fireLight.pointLightOuterRadius = maxFireLightRadius*(fireHealth/maxFireHealth);
        fireLight.intensity = 5f*fireHealth/maxFireHealth;
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
