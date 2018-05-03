using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public float restartDelay = 2f;
    public GameObject completeLevelUI;
    public void CompleteLevel()
    {
        Debug.Log("You Completed The Level");
        completeLevelUI.SetActive(true);
    }
    bool gameHasEnded = false;
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
    }
        void Restart() 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }







