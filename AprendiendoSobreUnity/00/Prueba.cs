/*
Titulo: "AprendiendoSobreUnity"
Hecho en el año:2019 
-----
Title: "AprendiendoSobreUnity"
Made in the year: 2019
*/
using UnityEngine;

public class Prueba : MonoBehaviour
{
    public Transform objetivo;
    void Start()
    {
        MostrarDistancia();
    }

    /// <summary>
    /// Este método muestra la distancia que hay entre el personaje y el objetivo.
    /// </summary>
   void MostrarDistancia()
    {
        float distancia = Vector3.Distance(transform.position, objetivo.position);
        Debug.Log("<color=#ECFF00> Distancia: </color>" + "<b>" + distancia.ToString() + "</b>");
    }
}
