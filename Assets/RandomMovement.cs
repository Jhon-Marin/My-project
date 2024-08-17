using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float speed;           // Velocidad del objeto
    public float directionChangeInterval; // Intervalo de cambio de direcci�n en segundos
    private Vector2 movementDirection;  // Direcci�n actual de movimiento
    private float timer;                // Temporizador para cambiar de direcci�n

    void Start()
    {
        // Iniciar la direcci�n de movimiento aleatoria
        ChooseRandomDirection();
    }

    void Update()
    {
        // Mover el objeto en la direcci�n actual
        transform.Translate(movementDirection * speed * Time.deltaTime);

        // Actualizar el temporizador y cambiar de direcci�n si es necesario
        timer += Time.deltaTime;
        if (timer >= directionChangeInterval)
        {
            ChooseRandomDirection();
            timer = 0f;
        }
    }

    void ChooseRandomDirection()
    {
        // Elegir una direcci�n aleatoria
        float randomAngle = Random.Range(0f, 360f); // �ngulo aleatorio en grados
        movementDirection = new Vector2(Mathf.Cos(randomAngle * Mathf.Deg2Rad), Mathf.Sin(randomAngle * Mathf.Deg2Rad));
        movementDirection.Normalize(); // Asegurarse de que la direcci�n tenga una magnitud de 1
    }
}
