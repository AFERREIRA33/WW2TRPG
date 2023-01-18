using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healer : Unite
{
    public healer()
    {
        Deplacement = 5;
        Pv = 20;
        Atk = 0;
        Def = 2;
    }

    public healer(int dep, int pv, int atk, int def)
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
