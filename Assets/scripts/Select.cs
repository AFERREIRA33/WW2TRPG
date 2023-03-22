using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Select : MonoBehaviour
{
    private Renderer render;
    public bool action;
    public bool select;
    public GameManager gameManager;

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
            
        }
    }
    private void OnMouseEnter()
    {

        if (!gameManager.isSelect)
        {
            if (action)
            {
                render.material.color = Color.green;
            }
        }
    }
    private void OnMouseUp()
    {
        Debug.Log("is select : " + gameManager.isSelect);
        Debug.Log("action : " + action);
        if (action && !gameManager.isSelect)
        {
            gameManager.isSelect = !gameManager.isSelect;
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
