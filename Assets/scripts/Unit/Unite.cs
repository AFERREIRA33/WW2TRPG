using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unite : MonoBehaviour
{
    public int Deplacement;
    public int Pv;
    public int Atk;
    public int Def;
    public int MaxPv;
    public int MaxAtk;
    public int MaxDef;

    public Unite()
    {
        Deplacement = 5;
        Pv = 15;
        Atk = 7;
        Def = 4;
        MaxPv = Pv;
        MaxAtk = Atk;
        MaxDef = Def;
    }

    public Unite(int dep, int pv, int atk, int def, int maxpv, int maxatk, int maxdef)
    {
        Deplacement = dep;
        Pv = pv;
        Atk = atk;
        Def = def;
        MaxPv = maxpv;
        MaxAtk = maxatk;
        MaxDef = maxdef;
    }

    public abstract void attack();

    public abstract void move();

}
