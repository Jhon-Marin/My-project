using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_DPA : MonoBehaviour
{

    public float speed = 2f;
    public float moveDistance = 10.001f;

    private Vector3 startPosition;
    private int direction = 1; // 1 for right, 2 for up, 3 for left, 4 for down

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        
        transform.Translate(Vector3.right * speed * Time.deltaTime * direction);
        float DistanceI = Vector2.Distance(transform.position, startPosition);

        if (DistanceI > moveDistance)
        {
           
            Debug.Log(DistanceI);
            
            direction++;
            if (direction > 4)
            {
                direction = 1;
            }

            switch (direction)
            {
                case 1:
                    transform.rotation = Quaternion.Euler(0, 0, 0);
                    startPosition = transform.position;
                    break;
                case 2:
                    transform.rotation = Quaternion.Euler(0, 0, 90);
                    startPosition = transform.position;
                    break;
                case 3:
                    transform.rotation = Quaternion.Euler(0, 0, 180);
                    startPosition = transform.position;
                    break;

                case 4:
                    transform.rotation = Quaternion.Euler(0, 0, -90);
                    startPosition = transform.position;
                    break;
            }
        }
    }
}