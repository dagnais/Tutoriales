/*
Titulo: "AprendiendoSobreUnity"
Hecho en el año:2019 
-----
Title: "AprendiendoSobreUnity"
Made in the year: 2019
*/
using UnityEngine;

public class Prueba2 : MonoBehaviour
{
    void Update()
    {
        if (ComprobarEntrada())
            Debug.Log("Vete a dormir");

        if (transform.position.y < 0)
        {
            transform.position = Vector3.zero;
            if (ComprobarEntrada())
                gameObject.SetActive(false);
        }
    }

    /// <summary>
    /// Este método comprueba el ingreso por teclado.
    /// </summary>
    /// <returns>devuelve verdadero si fue soltada la tecla z o v</returns>
    bool ComprobarEntrada()
    {
        if (Input.GetKeyUp(KeyCode.Z) || Input.GetKeyUp(KeyCode.V))
            return true;
        else
            return false;
    }
}
