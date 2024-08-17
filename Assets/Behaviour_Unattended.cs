using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behaviour_Unattended : MonoBehaviour
{
    public Vector3 scaleIncrement = new Vector3(0.1f, 0.1f, 0.1f); // Cantidad de escala que se incrementará
    public float interval = 3f; // Intervalo en segundos para hacer más grande el objeto
    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame

    void Update()
    {
        // Actualizar el temporizador
        timer += Time.deltaTime;

        // Verificar si ha pasado el intervalo de tiempo
        if (timer >= interval)
        {
            // Incrementar la escala del objeto
            transform.localScale += scaleIncrement;

            // Reiniciar el temporizador
            timer = 0f;
        }
    }
}
