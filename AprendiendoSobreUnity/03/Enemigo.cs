/*
Titulo: "AprendiendoSobreUnity"
Hecho en el año:2019 
-----
Title: "AprendiendoSobreUnity"
Made in the year: 2019
*/
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public static int enemigoCantidad = 0;
    private void Start()
    {
        
    }
    public Enemigo()
    {
        enemigoCantidad++;
    }
}
