using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class PLAYER : BaseEntidad
{
    public PLAYER(string name, int vida, int ataque, int defensa) : base(name, vida, ataque, defensa)
    {
    }

    public void Atacar(BaseEntidad enemigo)
    {
        int daño = Random.Range(5, Ataque + 1);
        Debug.Log(Name + " ataca a " + enemigo.Name + " causando " + daño + " de daño.");
        enemigo.RecibirDaño(daño);
    }
}
