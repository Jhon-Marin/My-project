using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tray_BC : MonoBehaviour
{
    public float speed = 3f;
    public GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
        Vector2 direction = (player.transform.position - transform.position).normalized;
        GetComponent<Rigidbody2D>().velocity = direction * speed;

    }

    void Update()
    {
        
    }

    /*void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Handle player hit
            // Destroy(gameObject);
            pass;
        }
        else
        {
            //Destroy(gameObject); // Destroy bullet if it hits something else
            pass;
        }
    }*/
}