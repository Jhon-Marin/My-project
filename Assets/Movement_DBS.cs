using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_DBS : MonoBehaviour
{
    public float velocidad = 1f; // Ajusta la velocidad del movimiento

    void Update()
    {
        // Movimiento diagonal hacia arriba a la derecha
        transform.Translate(Vector2.right * velocidad * Time.deltaTime);
        transform.Translate(Vector2.up * velocidad * Time.deltaTime);
    }
}
