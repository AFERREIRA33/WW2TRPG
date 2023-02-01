using System.Numerics;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Apple;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Plane = UnityEngine.Plane;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;
using System;

public class PlayerController : MonoBehaviour
{
    public Camera cam;
    public Transform planeMove;
    public int move;
    public PlaceObjectOnGrid grid;

    public NavMeshAgent agent;
    private Vector3 mousePosition;
    public Vector3 destination;

    private Plane plane;
    private int name = 0;
    private bool gridCreate = false;
    void Start()
    {
        
    }
    void Update()
    {
        if (Select.select)
        {
            if (Input.GetMouseButtonDown(0))
            {
                playerMove();
            }
            if (Math.Round(transform.position.x, 1) == destination.x && Math.Round(transform.position.z, 1) == destination.z && !gridCreate)
            {
                transform.eulerAngles = new Vector3(0f, 0f, 0f);
                transform.position = new Vector3((float)Math.Round(transform.position.x, 1), transform.position.y, (float)Math.Round(transform.position.z, 1));
                MoveGrid();
                gridCreate = true;

            }
        }
        
    }
    private void MoveGrid()
    {
        var line = move+1;
        for (int i = 0; i < move+1; i++)
        {
            Vector3 wP = new Vector3(transform.position.x+ i, 0.2f, transform.position.z);
            Vector3 wPR = new Vector3(transform.position.x - i, 0.2f, transform.position.z);
            PlaneCreate(wP);
            if(i > 0)
            {
                PlaneCreate(wPR);
            }
            for (int j = 1; j < line; j++)
            {
                PlaneCreate(new Vector3(wP.x, wP.y, wP.z + j));
                PlaneCreate(new Vector3(wPR.x, wPR.y, wPR.z + j));
                if(line >= 1)
                {
                    PlaneCreate(new Vector3(wP.x, wP.y, wP.z - j));
                    PlaneCreate(new Vector3(wPR.x, wPR.y, wPR.z - j));
                    
                }
            }
            line--;
        }
    }
    private void PlaneCreate(Vector3 wP)
    {
        print(grid.height);
        print(grid.width);
        if (wP.x >= 0 && wP.z >= 0 && wP.x < grid.height && wP.z < grid.width)
        {
            Transform obj = Instantiate(planeMove, wP, Quaternion.identity);
            obj.name = "moveCell" + name;
        }
        name++;
    }
    private void deleteGridB()
    {
        GameObject obj = GameObject.Find("moveCell" + name);
        Destroy(obj);
        name--;
    }
    private void playerMove()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            mousePosition = hit.point;
            if (Mathf.Round(mousePosition.x) >= 0 && Mathf.Round(mousePosition.z) >= 0)
            {
                if (hit.transform.name.Contains("moveCell"))
                {
                    Vector3 a = new Vector3(Mathf.Round(mousePosition.x), 0.5f, Mathf.Round(mousePosition.z));
                    destination = a;
                    agent.SetDestination(a);
                    while (name > 0 || GameObject.Find("moveCell" + name))
                    {
                        deleteGridB();
                    }
                    name = 0;
                    gridCreate = false;
                }
            }
        }
    }
}
