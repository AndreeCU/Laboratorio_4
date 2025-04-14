using System;
using UnityEngine;

public class SistemaCombate : MonoBehaviour
{
    void Start()
    {
        PLAYER jugador = new PLAYER("Valeria", 100, 20, 10);
        JEFEFINAL jefe = new JEFEFINAL("Arcan Dragon Rojo", 100, 18, 12);

        jugador.MostrarStats();
        jefe.MostrarStats();

        Debug.Log("La batalla comienza");

        int turno = 1;

        while (jugador.EstaVivo() && jefe.EstaVivo())
        {
            Debug.Log("------ TURNO " + turno + " ------");

            jugador.Atacar(jefe);

            if (jefe.EstaVivo())
            {
                jefe.Atacar(jugador);
            }

            turno++;
        }

        Debug.Log("------ FIN DE LA BATALLA ------");

        if (jugador.EstaVivo())
        {
            Debug.Log(jugador.Name + " ha ganado la batalla.");
        }
        else
        {
            Debug.Log(jefe.Name + " ha ganado la batalla.");
        }
    }
}



