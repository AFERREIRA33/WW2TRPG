using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    private Renderer render;
    public bool action;
    public bool select;
    void Start()
    {
        action = true;
        select = false;
        render = GetComponent<Renderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            action = true;
            Debug.Log("Reset");
        }
    }
    private void OnMouseEnter()
    {
        if (action == true)
        {
            render.material.color = Color.green;
        }
    }
    private void OnMouseUp()
    {
        if (action == true)
        {
            select = true;
            action = false;
            GetComponent<PlayerController>().enabled = true;
        }
    }
    private void OnMouseExit()
    {
        render.material.color = Color.white;
    }
}
