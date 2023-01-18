using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panzer : Unite
{
    public panzer()
    {
        Deplacement = 7;
        Pv = 30;
        Atk = 12;
        Def = 3;
    }

    public panzer(int dep, int pv, int atk, int def)
    {
        Deplacement = dep;
        Pv = pv;
        Atk = atk;
        Def = def;
    }
    public override void attack()
    {

    }

    public override void move()
    {

    }
}
