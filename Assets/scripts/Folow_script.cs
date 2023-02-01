using UnityEngine;
using UnityEngine.AI;


public class Folow_script : MonoBehaviour
{
    public NavMeshAgent Enemy;
    public Transform Player;
    void Start()
    {

    }
    void Update()
    {
        Enemy.SetDestination(Player.position);
    }
}