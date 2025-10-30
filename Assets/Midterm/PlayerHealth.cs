using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float playerHealth = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float currentHealth = 50f;
        float maxHealth = 100f;
        float damage = 5.0f;
        float heal = 10f;
        playerHealth = playerHealth - damage;
        playerHealth += heal;

        currentHealth = maxHealth; 

     


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
