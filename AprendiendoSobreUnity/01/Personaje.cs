﻿using UnityEngine;

public class Personaje : MonoBehaviour
{
    int experiencia;
    public int Experiencia
    {
        get { return experiencia; }
        set { experiencia = value; }
    }

    public int Nivel
    {
        get { return experiencia / 1000; }
        set { experiencia = value * 1000; }
    }

    public int Vida { get; set; }
}
