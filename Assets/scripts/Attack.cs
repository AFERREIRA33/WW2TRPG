using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameManager gameManager;
    public AudioSource Sound;

     public void attackfunction(GameObject h)
    {
        GameObject v = transform.gameObject;
        if (h)
        {
            if (Sound.isPlaying == false)
            {
                Sound.Play();
            }
            h.GetComponent<infant>().setPv(v.GetComponent<infant>().Atk - h.GetComponent<infant>().Def);
            Debug.Log(h.GetComponent<infant>().Pv);
            if(h.GetComponent<infant>().Pv<=0)
            {
                if(h.tag == "ennemy")
                {
                    gameManager.EnnemyDeath();
                } else
                {
                    gameManager.PlayerDeath();
                }
                
                Destroy(h);
            }
        }

    }
}
