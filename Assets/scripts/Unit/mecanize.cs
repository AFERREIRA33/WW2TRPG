using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mecanize : Unite
{
    public mecanize()
    {
        Deplacement = 10;
        Pv = 10;
        Atk = 8;
        Def = 2;
    }

    public mecanize(int dep, int pv, int atk, int def)
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
