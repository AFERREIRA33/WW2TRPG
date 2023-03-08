using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class artillerie : MonoBehaviour
{
    public int Deplacement;
    public int Pv;
    public int Atk;
    public int Def;
    public int MaxPv;


    public artillerie()
    {
        Deplacement = 2;
        Pv = 17;
        Atk = 10;
        Def = 5;
        MaxPv = Pv;

    }

    public artillerie(int dep, int pv, int atk, int def, int maxpv, int maxatk, int maxdef)
    {
        Deplacement = dep;
        Pv = pv;
        Atk = atk;
        Def = def;
        MaxPv = maxpv;

    }

    public void setPv(int damage)
    {
        if (damage <= 0)
        {
            damage = 0;
        }
        Debug.Log(damage);
        Pv -= damage;
    }
}
