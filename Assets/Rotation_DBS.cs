using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_DBS : MonoBehaviour
{
    public GameObject objetoAAdherir; // El objeto al que se adhiere
    public float velocidadRotacion = 20f; // Velocidad de rotaci�n en grados por segundo

    void Update()
    {
        // Rotaci�n continua
        transform.Rotate(Vector3.forward * velocidadRotacion * Time.deltaTime);

        // Mantener posici�n relativa al objeto a adherir
        transform.position = objetoAAdherir.transform.position;
    }
}