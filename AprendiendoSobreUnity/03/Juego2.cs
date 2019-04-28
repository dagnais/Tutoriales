using UnityEngine;

public class Juego2 : MonoBehaviour
{
    private void Start()
    {
        Enemigo enemigo1 = new Enemigo();
        Enemigo enemigo2 = new Enemigo();
        Enemigo enemigo3 = new Enemigo();
        Debug.Log(Enemigo.enemigoCantidad);
    }
}
