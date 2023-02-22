using UnityEngine.SceneManagement;
using UnityEngine;

public class Goal : MonoBehaviour
{
    
    public int goal = 10; 
    private int destroyed = 0; 

    public void Ennemy_kill()
    { 
        destroyed++;
        if (destroyed >= goal) SceneManager.LoadScene("WIN");
    }
}
