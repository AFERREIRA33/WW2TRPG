using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class artillerie : Unite
{
    public artillerie()
    {
        Deplacement = 2;
        Pv = 17;
        Atk = 10;
        Def = 5;
    }

    public artillerie(int dep, int pv, int atk, int def)
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
