using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panzer : MonoBehaviour
{
    public int Deplacement;
    public int Pv;
    public int Atk;
    public int Def;
    public int MaxPv;


    public panzer()
    {
        Deplacement = 7;
        Pv = 30;
        Atk = 12;
        Def = 3;
        MaxPv = Pv;

    }

    public panzer(int dep, int pv, int atk, int def, int maxpv, int maxatk, int maxdef)
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
