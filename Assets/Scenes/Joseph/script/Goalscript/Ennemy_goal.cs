using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy_goal : MonoBehaviour
{
    void OnDestroy()
    {
        FindObjectOfType<Defeat>().Allied_down();
    }
}
