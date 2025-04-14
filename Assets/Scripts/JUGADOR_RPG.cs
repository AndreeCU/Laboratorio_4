using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JUGADOR_RPG : MonoBehaviour
{
    private int nivel;

    public int Nivel
    {
        get { return nivel; }
        set
        {
            if (value >= 1)
            {
                nivel = value;
            }
            else
            {
                Debug.Log("El nivel debe ser al menos 1");
            }
        }
    }
}
