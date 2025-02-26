using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 5;
    private float currentHealth;

    private void Awake()
    {
        currentHealth = startingHealth;
    }
    public void Kill()
    {
        Destroy(gameObject);
    }

    public void ChangingHealth(float changesAmount)
    {
        currentHealth = currentHealth + changesAmount;
        currentHealth = Mathf.Clamp(currentHealth, 0, startingHealth);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth == 0)
        {
            Kill();
        }
    }
}
