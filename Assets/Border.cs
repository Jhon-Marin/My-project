using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    public float borderWidth = 1f; // Adjust border width as needed

    void Start()
    {
        Camera mainCamera = Camera.main;
        float screenHeight = mainCamera.orthographicSize * 2f;
        float screenWidth = screenHeight * mainCamera.aspect;
        
        // Create visual border (optional)
        GameObject borderObject = new GameObject("Border");
        /*
        SpriteRenderer spriteRenderer = borderObject.AddComponent<SpriteRenderer>();
        // Assign your border sprite here
        spriteRenderer.sprite = yourBorderSprite;
        */
        // Create collision border
        BoxCollider2D collider = gameObject.AddComponent<BoxCollider2D>();
        collider.size = new Vector2(screenWidth + borderWidth * 2f, screenHeight + borderWidth * 2f);
    }
   
}