using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    private AbilityMC abilityScript;
    bool TeletransportValue = true;
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        // Obtiene la posici�n del cursor en la pantalla
        Vector3 mousePosition = Input.mousePosition;

        // Convierte la posici�n del cursor de la pantalla a un punto en el espacio 2D
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        abilityScript = GetComponent<AbilityMC>();
        if (abilityScript != null)
        {
            TeletransportValue = abilityScript.teletransport;
            if (TeletransportValue)
            {
                // Asigna la posici�n del objeto a la posici�n calculada en el mundo 2D (X, Y)
                transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
            }
        }
        else
        {
            Debug.LogError("No se encontr� el script Ability en el objeto.");
        }

        // Si el script Ability est� en otro objeto, usa:
        // abilityScript = GameObject.Find("NombreDelObjetoConAbility").GetComponent<Ability>();

        // Acceder a la variable teletransport del script Ability



       

       
        

        
    }
}

