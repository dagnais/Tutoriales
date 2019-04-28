/*
Titulo: "AprendiendoSobreUnity"
Hecho en el año:2019 
-----
Title: "AprendiendoSobreUnity"
Made in the year: 2019
*/
using UnityEngine;

public class Juego : MonoBehaviour
{
    void Start()
    {
        Personaje personaje = new Personaje();
        personaje.Experiencia = 5;
        Debug.Log(personaje.Experiencia);
    }
}
