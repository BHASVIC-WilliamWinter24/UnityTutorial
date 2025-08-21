using UnityEditor.Build.Content;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance; // basically a static object 

    [SerializeField]
    private GameObject[] players;

    private int _playerIndex;
    public int PlayerIndex
    {
        get { return _playerIndex; }
        set { _playerIndex = value; }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
}
