using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiSeekPlayer : MonoBehaviour
{
    public GameObject MainCharacter;
    private float distance;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, MainCharacter.transform.position);
        Vector2 direction = MainCharacter.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, MainCharacter.transform.position, speed * Time.deltaTime);
        
    }
}