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
    public Select s;
    public Camera cam;
    public Transform planeMove;
    public float move;
    public PlaceObjectOnGrid grid;
    public GameManager gameManager;
    public NavMeshAgent agent;
    private Vector3 mousePosition;
    public Vector3 destination;
    public Attack attack;

    private int nameGrid = 0;
    private bool gridCreate = false;
    void Start()
    {
        destination = transform.position;
    }
    void Update()
    {
        if (s.select)
        {
            if (Math.Round(transform.position.x, 1) == destination.x && Math.Round(transform.position.z, 1) == destination.z && !gridCreate)
            {
                transform.eulerAngles = new Vector3(0f, 0f, 0f);
                transform.position = new Vector3((float)Math.Round(transform.position.x, 1), transform.position.y, (float)Math.Round(transform.position.z, 1));
                MoveGrid();
                gridCreate = true;
            }
            if (Input.GetMouseButtonDown(0))
            {
                playerMove();
            }
        }


    }
    private void MoveGrid()
    {
        var line = move + 1;
        for (int i = 0; i < move + 1; i++)
        {
            Vector3 wP = new Vector3(transform.position.x + i, 0.2f, transform.position.z);
            Vector3 wPR = new Vector3(transform.position.x - i, 0.2f, transform.position.z);
            PlaneCreate(wP);
            if (i > 0)
            {
                PlaneCreate(wPR);
            }
            for (int j = 1; j < line; j++)
            {
                PlaneCreate(new Vector3(wP.x, wP.y, wP.z + j));
                PlaneCreate(new Vector3(wPR.x, wPR.y, wPR.z + j));
                if (line >= 1)
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
        if (wP.x >= 0 && wP.z >= 0 && wP.x < grid.height && wP.z < grid.width)
        {
            Collider[] intersecting = Physics.OverlapSphere(wP, 0.01f);
            if (intersecting.Length == 0)
            {
                Transform obj = Instantiate(planeMove, wP, Quaternion.identity);
                obj.name = "moveCell" + nameGrid;
            }
        }
        nameGrid++;
    }
    private void deleteGridB()
    {
        GameObject obj = GameObject.Find("moveCell" + nameGrid);
        Destroy(obj);
        nameGrid--;
        s.gameManager.isSelect = false;
    }
    private void playerMove()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            mousePosition = hit.point;

            if (hit.transform.gameObject.tag == "ennemy" && mousePosition.x < transform.position.x + move - 0.6 && mousePosition.x > transform.position.x - move + 0.6 && mousePosition.z < transform.position.z + move - 0.6 && mousePosition.z > transform.position.z - move + 0.6)
            {
                attack.attackfunction(hit.transform.gameObject);
                while (nameGrid > 0 || GameObject.Find("moveCell" + nameGrid))
                {
                    deleteGridB();
                }
                nameGrid = 0;
                gridCreate = false;
                s.select = false;
                gameManager.perso_turn--;
                Debug.Log(gameManager.perso_turn);
            }
            if (Mathf.Round(mousePosition.x) >= 0 && Mathf.Round(mousePosition.z) >= 0)
            {
                if (hit.transform.name.Contains("moveCell"))
                {
                    destination = new Vector3(Mathf.Round(mousePosition.x), 0.5f, Mathf.Round(mousePosition.z));

                    agent.SetDestination(destination);
                    while (nameGrid > 0 || GameObject.Find("moveCell" + nameGrid))
                    {
                        deleteGridB();
                    }
                    nameGrid = 0;
                    gridCreate = false;
                    s.select = false;
                    gameManager.perso_turn--;
                }
            }
        }

    }
}
