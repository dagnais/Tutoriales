using UnityEngine;

public class UtilidadesEjemplo : MonoBehaviour
{
    private void Start()
    {
        int valor = Utilidades.Agregar(5, 6);
        Debug.Log(valor);
    }
}
