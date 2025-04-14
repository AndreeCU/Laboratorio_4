using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENEMIGO : MonoBehaviour
{
    private string nombreEnemigo;


    public string NombreEnemigo => nombreEnemigo;


    public void Enemigo(string _nombreenemigo)
    {
        nombreEnemigo = _nombreenemigo;
    }
}
