using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityMC : MonoBehaviour
{
    public GameObject sword;
    public bool teletransport = true;
    // Start is called before the first frame update
    void Start()
    {
        teletransport = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("La tecla Q fue presionada");
            sword.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            Debug.Log("La teclaQ fue soltada");
            // Lógica cuando se suelta la tecla Q
            sword.SetActive(false);

            
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("La tecla W fue presionada");
            // Lógica adicional para la tecla W
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("La tecla E fue presionada");

            // Lógica adicional para la tecla E
            teletransport = false;
        }
        // Detecta cuando se suelta la tecla E
        if (Input.GetKeyUp(KeyCode.E))
        {
            Debug.Log("La tecla E fue soltada");
            // Lógica cuando se suelta la tecla E
            teletransport= true;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("La tecla R fue presionada");
            // Lógica adicional para la tecla R
        }

    }
}
