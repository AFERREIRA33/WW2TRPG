using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int perso_player;
    public int perso_enemy;
    public int perso_turn;
    public bool isSelect = false;
    public GameObject[] allPlayer;
    private void Start()
    {
        allPlayer = GameObject.FindGameObjectsWithTag("Player");
        perso_player = 2;
        perso_enemy = 1;
        perso_turn = 2;
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
    private bool change_turn_perso()
    {
        if (perso_turn == 0)
        {
            return true;
        }
        return false;
    }
    public void end_player_turn()
    {
        if (change_turn_perso() == true){
             Debug.Log("On change de tour");
             perso_turn = perso_player;
             Debug.Log("perso_turn : " + perso_turn);
            Debug.Log("perso_player : " + perso_player);
             foreach(GameObject aPlayer in allPlayer)
            {
                aPlayer.GetComponent<Select>().action = true;
            }
        }
        else{
             Debug.Log("il reste " + perso_turn + " qui n'ont pas encore jouer.");
       }
    }
}
