using UnityEngine.SceneManagement;
using UnityEngine;
public class Defeat : MonoBehaviour
{
    public int allied = 10;
    private int kill = 0;
    public void Allied_down()
    {
        kill++;
        if (kill >= 10) SceneManager.LoadScene("LOSE");
    }
}
