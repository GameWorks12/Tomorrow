using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{


    public int maxHealth = 100;
    public int currentHealth;
    public HealthSystem healthSystem;
    public Health health;

    private Vector2 pointerInput;

    private Rigidbody2D RB;


    public float speed = 0.2f;
    public CharacterController Controller;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthSystem.SetMaxHealth(maxHealth);
        Controller = GetComponent<CharacterController>();
        RB = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(x * speed, y * speed);

        transform.Translate(movement);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            health.Damage(20);
        }
    }

        
    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthSystem.SetHealth(currentHealth);
    }


}
