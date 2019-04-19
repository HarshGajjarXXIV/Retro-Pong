using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultyMenu : MonoBehaviour
{
    public static float AISpeed;
    public void Easy() {
        AISpeed = 7f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Medium() {
        AISpeed = 10f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Hard() {
        AISpeed = 14f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
