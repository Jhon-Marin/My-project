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

    public GameObject background;
    private Vector3 m_Size;
    
    void Start()
    {
        // Calculate screen boundaries based on camera or screen dimensions
        // Adjust for player size if necessary
        
        var m_Collider=background.GetComponent<BoxCollider2D>();
        m_Size = m_Collider.bounds.size;
        float width = m_Size.x;
        float height = m_Size.y;
        screenRight = m_Size.x / 2;
        screenLeft = -screenRight;
        screenTop = m_Size.y / 2;
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
