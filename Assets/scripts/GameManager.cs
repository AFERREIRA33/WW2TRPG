using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public int perso_player;
    public int perso_enemy;
    public int perso_turn;
    public bool isSelect = false;
    public GameObject[] allPlayer;
    public TMP_Text txtEndTurn;
    public TMP_Text live;
    public Image def;
    public Image vic;
    public void Start()
    {
        Invoke("DelayedAction", 5f);
        allPlayer = GameObject.FindGameObjectsWithTag("Player");
        perso_player = 2;
        perso_enemy = 2;
        perso_turn = 2;
        
    }

    void Update()
    {
        live.SetText("Unit�e encore envie: " + perso_player + "\n \n" + "Unit�e enemie d�tecter: " + perso_enemy);
        

        if (Dead() == true) {
            Debug.Log("Dead");
            def.enabled = true;
            DelayedAction();
        }
        if (Dead_enemy() == true) {
            Debug.Log("Victoire");
            vic.enabled = true;
            DelayedAction();

        }
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
    public void DelayedAction()
    {
        Debug.Log("tewt");
       /// SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void end_player_turn()
    {
        if (change_turn_perso() == true){
            Debug.Log("On change de tour");
            perso_turn = perso_player;
            Debug.Log("perso_turn : " + perso_turn);
            Debug.Log("perso_player : " + perso_player);
            txtEndTurn.SetText("");
             foreach (GameObject aPlayer in allPlayer)
            {
                aPlayer.GetComponent<Select>().action = true;
            }
        }
        else{
            txtEndTurn.SetText("il reste " + perso_turn + " qui n'ont pas encore jouer.");
       }
    }
    public void Death()
    {
        perso_enemy--;
    }
}
