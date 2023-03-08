using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mecanize : MonoBehaviour
{
    public int Deplacement;
    public int Pv;
    public int Atk;
    public int Def;
    public int MaxPv;


    public mecanize()
    {
        Deplacement = 10;
        Pv = 10;
        Atk = 8;
        Def = 2;
        MaxPv = Pv;

    }

    public mecanize(int dep, int pv, int atk, int def, int maxpv, int maxatk, int maxdef)
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
