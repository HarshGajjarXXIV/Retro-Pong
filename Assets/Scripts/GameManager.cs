using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int playerScore01 = 0;
    public static int playerScore02 = 0;
    public GUISkin theSkin;

    // Update is called once per frame
    public static void Score(string wallName)
    {
        if(wallName == "rightWall") {
            playerScore01 += 1;
        } else {
            playerScore02 += 1;
        }
    }

    void OnGUI() {
        GUI.skin = theSkin;
        GUI.Label(new Rect(Screen.width/2-150-12, 20, 100, 100), "" + playerScore01);
        GUI.Label(new Rect(Screen.width/2+150-12, 20, 100, 100), "" + playerScore02);
    }
}
