using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Campfire : MonoBehaviour
{
    public float maxFireHealth = 200f;
    public float fireHealth = 100f;
    public float burnRate = 5f;
    public Light2D fireLight;
    public float maxFireLightRadius = 10f;

    void Update()
    {
        if (fireHealth > 20f)
        {
            fireHealth -= burnRate*Time.deltaTime;
            fireLight.pointLightOuterRadius = maxFireLightRadius*(fireHealth/maxFireHealth);
            fireLight.intensity = 5f*fireHealth/maxFireHealth;
        }
        else
        {
            fireLight.pointLightOuterRadius = 0;
            fireLight.intensity = 0;
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