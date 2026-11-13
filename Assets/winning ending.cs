using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;
    public void CompleteLevel()
    {
        Debug.Log("LEVEL WON");
    }

}