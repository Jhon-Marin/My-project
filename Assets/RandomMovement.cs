using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float speed;           // Velocidad del objeto
    public float directionChangeInterval; // Intervalo de cambio de dirección en segundos
    private Vector2 movementDirection;  // Dirección actual de movimiento
    private float timer;                // Temporizador para cambiar de dirección

    void Start()
    {
        // Iniciar la dirección de movimiento aleatoria
        ChooseRandomDirection();
    }

    void Update()
    {
        // Mover el objeto en la dirección actual
        transform.Translate(movementDirection * speed * Time.deltaTime);

        // Actualizar el temporizador y cambiar de dirección si es necesario
        timer += Time.deltaTime;
        if (timer >= directionChangeInterval)
        {
            ChooseRandomDirection();
            timer = 0f;
        }
    }

    void ChooseRandomDirection()
    {
        // Elegir una dirección aleatoria
        float randomAngle = Random.Range(0f, 360f); // Ángulo aleatorio en grados
        movementDirection = new Vector2(Mathf.Cos(randomAngle * Mathf.Deg2Rad), Mathf.Sin(randomAngle * Mathf.Deg2Rad));
        movementDirection.Normalize(); // Asegurarse de que la dirección tenga una magnitud de 1
    }
}
