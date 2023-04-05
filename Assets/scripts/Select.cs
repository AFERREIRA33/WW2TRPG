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
    public AudioSource Selectsound;

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
                transform.GetChild(1).GetComponent<Renderer>().material.color = Color.green;
                if (Selectsound.isPlaying == false)
                {
                    Selectsound.Play();
                }
            }
        }
    }
    private void OnMouseUp()
    {
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
        transform.GetChild(1).GetComponent<Renderer>().material.color = Color.clear;
    }
 
}
