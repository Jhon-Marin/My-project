using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiSeekPlayer : MonoBehaviour
{
    private float distance;
    public float speed;
    public float delay = 1f;
    private bool triggered = false;
    private float timer = 0f;
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
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
        else {
            distance = Vector2.Distance(transform.position, player.transform.position);
            Vector2 direction = player.transform.position - transform.position;

            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
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

    

 