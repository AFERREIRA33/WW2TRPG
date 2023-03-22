using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using UnityEngine.AI;
using Vector3 = UnityEngine.Vector3;
using System;

public class Ennemy_IA : MonoBehaviour
{

    public NavMeshAgent agent;
    public bool ennemy_turn = false;
    public Vector3 destination;
    public Vector3 distancemax;
    public GameObject[] allEnnemies;
    public Attack attack;
    public GameManager manager;

    void Start()
    {
        allEnnemies = GameObject.FindGameObjectsWithTag("Player");
        destination = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (ennemy_turn){
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
            transform.position = new Vector3((float)Math.Round(transform.position.x, 1), transform.position.y, (float)Math.Round(transform.position.z, 1));
            Ennemymove();
        }
    }

    private void Ennemymove()
    {
        
        GameObject att = allEnnemies[0];
        float distbettwo = Vector3.Distance(allEnnemies[0].transform.position, transform.position);
        Vector3 destennemy = allEnnemies[0].transform.position;
        foreach (GameObject player in allEnnemies)
        {
            if (Vector3.Distance(player.transform.position,transform.position) <= distbettwo)
            {
                distbettwo = Vector3.Distance(player.transform.position, transform.position);
                destennemy = player.transform.position;
                att = player;
            }
        }
        if (distbettwo <= 4)
        {
            attack.attackfunction(att);
            ennemy_turn = false;
        } else
        {
            
            float posx = Mathf.Clamp(destennemy.x, 4, destennemy.x-1f);
            float posz = Mathf.Clamp(destennemy.z, 4, destennemy.z-1f);
            destination = new Vector3(posx,0.5f,posz);
            agent.SetDestination(destination);
            ennemy_turn = false;
        }

    }
    
    public void Turn()
    {
        ennemy_turn = true;
        allEnnemies = GameObject.FindGameObjectsWithTag("Player");
        destination = transform.position;
    }
}
