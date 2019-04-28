using UnityEngine;

public class OperadorTernario : MonoBehaviour
{
    void Start()
    {
        int vida = 10;
        string mensaje;
        mensaje = vida > 0 ? "Estoy vivo" : "He muerto";
        
    }
}
