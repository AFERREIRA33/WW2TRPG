using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class PlaceObjectOnGrid : MonoBehaviour
{
    public Transform gridCellPrefabs;
    public Transform cube;

    public int height;
    public int width;

    public NavMeshAgent agent;

    private Vector3 cubeCoord;

    private Vector3 mousePosition;
    private Node[,] nodes;
    private Plane plane;
    private Transform cb;
    void Start()
    {
        CreateGrid();

    }
    private void CreateGrid()
    {
        nodes = new Node[width, height];
        var name = 0;
        for (int i= 0; i<width; i++)
        {
            for (int j= 0; j<height; j++)
            {
                Vector3 worldPosition = new Vector3(i, 0, j);
                Transform obj = Instantiate(gridCellPrefabs, worldPosition, Quaternion.identity);
                obj.name = "Cell " + name;
                nodes[i, j] = new Node(true, worldPosition, obj);
                name++;
            }
        }
    }
}

public class Node
{
    public bool isPlaceable;
    public Vector3 cellPosition;
    public Transform obj;
    public Node(bool isPlaceable, Vector3 cellPosition, Transform obj)
    {
        this.isPlaceable = isPlaceable;
        this.cellPosition = cellPosition;
        this.obj = obj;
    }
}