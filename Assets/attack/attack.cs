using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{

    static public void attackfunction(string h, string v)
    {
        GameObject go = GameObject.Find(h);
        GameObject goactual = GameObject.Find(v);
        if (go)
        {
            go.GetComponent<infant>().setPv(goactual.GetComponent<infant>().Atk - go.GetComponent<infant>().Def);
            if(go.GetComponent<infant>().Pv<=0)
            {
                Destroy(go);
            }
        }

    }
}
