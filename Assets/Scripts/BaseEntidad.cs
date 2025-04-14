using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEntidad : MonoBehaviour
{
    public string Name;
    protected int Vida;
    protected int Ataque;
    protected int Defensa;

    public BaseEntidad(string _name, int _vida, int _ataque, int _defensa)
    {
        Name = _name;
        Vida = _vida;
        Ataque = _ataque;
        Defensa = _defensa;
    }

    public void MostrarStats()
    {
        Debug.Log(Name + " - Vida: " + Vida + " | Ataque: " + Ataque + " | Defensa: " + Defensa);
    }

    public bool EstaVivo()
    {
        return Vida > 0;
    }

    public virtual void RecibirDaño(int daño)
    {
        Vida -= daño;
        if (Vida < 0) Vida = 0;
        Debug.Log(Name + " recibió " + daño + " de daño. Vida restante: " + Vida);
    }
}
