using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;
    private Transform theBall;

    void Start() {
        theBall = GameObject.FindGameObjectWithTag("Ball").transform;
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if(gameIsPaused) {
                ResumeGame();
            } else {
                PauseGame();
            }
        }
    }

    public void ResumeGame() {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    void PauseGame() {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void ResetGame() {
        GameManager.playerScore01 = 0;
        GameManager.playerScore02 = 0;
        theBall.gameObject.SendMessage("ResetBall");
        ResumeGame();
    }

    public void MainMenu() {
        Time.timeScale = 1f;
        GameManager.playerScore01 = 0;
        GameManager.playerScore02 = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void QuitGame() {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
