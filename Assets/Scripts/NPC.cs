using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private string npcName;
    private int energy;
    protected float speed;


    public string NpcName => npcName;
    public int Energy => energy;
    public float Speed => speed;

    public void Set(string _npcName, int _energy, float _speed)
    {
        npcName = _npcName;
        energy = _energy;
        speed = _speed;
    }
}
