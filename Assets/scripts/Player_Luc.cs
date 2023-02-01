using UnityEngine;
using UnityEngine.AI;

public class Player_Luc : MonoBehaviour
{
    public Camera cam;

    public NavMeshAgent agent;
    private Vector3 destination;

    void Update()
    {
        if (Select.select == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                


                if (Physics.Raycast(ray, out hit))
                {
                    destination = hit.point;
                    agent.SetDestination(hit.point);
                    GetComponent<Player_Luc>().enabled = false;
                }
            }
        }
        if (transform.position.x == destination.x && transform.position.z == destination.z)
        {
            
        }
    }
}
