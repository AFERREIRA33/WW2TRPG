using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Allied_Goal : MonoBehaviour
{
    void OnDestroy()
    {
        FindObjectOfType<Goal>().Ennemy_kill();
    }
}
