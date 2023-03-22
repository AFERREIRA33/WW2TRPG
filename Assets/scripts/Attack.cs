using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameManager gameManager;

     public void attackfunction(GameObject h)
    {
        GameObject v = transform.gameObject;
        if (h)
        {
            h.GetComponent<infant>().setPv(v.GetComponent<infant>().Atk - h.GetComponent<infant>().Def);
            Debug.Log(h.GetComponent<infant>().Pv);
            if(h.GetComponent<infant>().Pv<=0)
            {
                gameManager.Death();
                Destroy(h);
                
            }
        }

    }
}
