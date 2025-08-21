using Unity.Multiplayer.Center.Common;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        string clickedObject = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        int index;
        if (clickedObject == "Player 1 Select")
            index = 0;
        else
            index = 1;
        GameController.instance.PlayerIndex = index; // passes index into the static instance of the GameController
        SceneManager.LoadScene("Monster Chase Gameplay");

    }
}
