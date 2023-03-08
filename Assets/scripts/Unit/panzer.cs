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
        Deplacement = 5;
        Pv = 15;
        Atk = 7;
        Def = 4;
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
}
