using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int perso_player = 2;
    public int perso_enemy = 1;
    public int perso_turn = 2;
    public bool isSelect = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (change_turn_perso() == true)
            {
                Debug.Log("On change de tour");
            }
            else
            {
                Debug.Log("il reste " + perso_turn + " qui n'ont pas encore jouer.");
            }
        };

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
    private bool change_turn_perso()
    {
        if (perso_turn == 0)
        {
            return true;
        }
        return false;
    }
}
