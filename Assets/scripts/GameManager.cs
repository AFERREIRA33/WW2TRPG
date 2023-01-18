using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int perso_player = 10;
    public int perso_enemy = 10;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Dead() == true) { Debug.Log("Perdu"); }
        if (Dead_enemy() == true) { Debug.Log("Gagner"); }
    }
    private bool Dead()
    {
        if (perso_player == 0)
        {
            return true;
        }
        return false;
    }
    private bool Dead_enemy()
    {
        if (perso_enemy == 0)
        {
            return true;
        }
        return false;
    }
}
