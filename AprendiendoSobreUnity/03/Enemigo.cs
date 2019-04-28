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
