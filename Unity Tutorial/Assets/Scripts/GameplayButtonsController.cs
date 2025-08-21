using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayButtonsController : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("Monster Chase Gameplay");

    }

    public void Home()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
