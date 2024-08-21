using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDIT : MonoBehaviour
{
    public float delay = 1f;
    public float speed = 5f;
    private bool triggered = false;
    private float timer = 0f;
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (triggered)
        {
            timer += Time.deltaTime;
            if (timer >= delay)
            {
                triggered = false;
                Vector2 direction = (player.position - transform.position).normalized;
                GetComponent<Rigidbody2D>().velocity = direction * speed;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("atacar");
            triggered = true;
            timer = 0f;
        }
    }
}