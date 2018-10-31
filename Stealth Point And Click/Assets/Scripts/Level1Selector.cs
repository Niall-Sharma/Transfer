using UnityEngine.SceneManagement;
using UnityEngine;

public class Level1Selector : MonoBehaviour {
    public void Selectlevel1(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
