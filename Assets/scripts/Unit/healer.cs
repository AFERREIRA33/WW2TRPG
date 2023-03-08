using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healer : MonoBehaviour
{
    public int Deplacement;
    public int Pv;
    public int Atk;
    public int Def;
    public int MaxPv;


    public healer()
    {
        Deplacement = 5;
        Pv = 20;
        Atk = 0;
        Def = 2;
        MaxPv = Pv;

    }

    public healer(int dep, int pv, int atk, int def, int maxpv, int maxatk, int maxdef)
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
