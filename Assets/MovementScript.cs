using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    private AbilityMC abilityScript;
    bool TeletransportValue = true;
    public float sensitivity;  // Sensibilidad del cursor (1.0 es la sensibilidad normal)
    private Vector2 mousePosition;    // Almacena la posición del cursor
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false;
        // Obtiene la posición del cursor en la pantalla
        Vector3 mousePosition = Input.mousePosition;

        // Convierte la posición del cursor de la pantalla a un punto en el espacio 2D
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        abilityScript = GetComponent<AbilityMC>();
        if (abilityScript != null)
        {
            TeletransportValue = abilityScript.teletransport;
            if (TeletransportValue)
            {
                // Asigna la posición del objeto a la posición calculada en el mundo 2D (X, Y)
                transform.position = new Vector3(mousePosition.x , mousePosition.y, transform.position.z);
            }
        }
        else
        {
            Debug.LogError("No se encontró el script Ability en el objeto.");
        }

        // Si el script Ability está en otro objeto, usa:
        // abilityScript = GameObject.Find("NombreDelObjetoConAbility").GetComponent<Ability>();

        // Acceder a la variable teletransport del script Ability



       

       
        

        
    }
}

