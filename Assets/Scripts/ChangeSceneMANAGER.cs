using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneMANAGER : MonoBehaviour
{
    public void LoadsceneGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void LoadsceneMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
