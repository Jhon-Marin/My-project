using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrapAround : MonoBehaviour
{
    // Start is called before the first frame update
    public float screenRight;
    public float screenLeft;
    public float screenTop;
    public float screenBottom;

    void Start()
    {
        // Calculate screen boundaries based on camera or screen dimensions
        // Adjust for player size if necessary
        screenRight = Camera.main.orthographicSize * Screen.width / Screen.height;
        screenLeft = -screenRight;
        screenTop = Camera.main.orthographicSize;
        screenBottom = -screenTop;
    }

    void Update()
    {
        // Check for out-of-bounds conditions and teleport if necessary
        if (transform.position.x > screenRight)
        {
            transform.position = new Vector3(screenLeft, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < screenLeft)
        {
            transform.position = new Vector3(screenRight, transform.position.y, transform.position.z);
        }

        if (transform.position.y > screenTop)
        {
            transform.position = new Vector3(transform.position.x, screenBottom,
 transform.position.z);
        }
        else if (transform.position.y < screenBottom)
        {
            transform.position = new Vector3(transform.position.x, screenTop, transform.position.z);
        }
    }
}
