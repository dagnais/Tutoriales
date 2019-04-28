using UnityEngine;

public class Prueba3 : MonoBehaviour
{
    void Start()
    {
        Invoke("MostrarTiempo", 2);
    }

    /// <summary>
    /// Muestra el tiempo actual.
    /// Es llamado por un Invoke en el método Start.
    /// </summary>
    void MostrarTiempo()
    {
        Debug.Log(Time.time);
    }
}
