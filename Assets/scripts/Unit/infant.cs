using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infant : Unite
{
    public GameManager gameManager;
    public Enemy enemy;
    public GameObject select_enemy = null;
    public infant()
    {
        Deplacement = base.Deplacement;
        Pv = base.Pv;
        Atk = base.Atk;
        Def = base.Def;
        MaxPv = Pv;
        MaxAtk = Atk;
        MaxDef = Def;

    }

    public infant(int dep, int pv, int atk, int def)
    {
        Deplacement = dep;
        Pv = pv;
        Atk = atk;
        Def = def;
    }
    public override void attack()
    {
        if (Pv - Atk > 0)
        {
            Pv = Pv - Atk;
        }
        else
        {
            Pv = 0;
            Destroy(this.gameObject);
            print("Vous êtes mort");
            gameManager.perso_player--;
        }
    }
    public override void move()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
            
        {
            if (select_enemy != null)
            attack();
            print (Pv);
            
        }
    }

}
