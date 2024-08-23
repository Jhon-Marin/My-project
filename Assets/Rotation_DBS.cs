using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_DBS : MonoBehaviour
{
    public GameObject objetoAAdherir; // El objeto al que se adhiere
    public float velocidadRotacion = 20f; // Velocidad de rotación en grados por segundo

    void Update()
    {
        // Rotación continua
        transform.Rotate(Vector3.forward * velocidadRotacion * Time.deltaTime);

        // Mantener posición relativa al objeto a adherir
        transform.position = objetoAAdherir.transform.position;
    }
}