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
