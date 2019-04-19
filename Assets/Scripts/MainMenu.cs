using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static bool isAI;

    private void Start() {
        isAI = true;
    }
    public void Play2P() {
        isAI = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Quit() {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
