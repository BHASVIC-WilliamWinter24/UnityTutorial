using System;
using UnityEditor.Build.Content;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); // destroy if duplicate
        }
    }

    private void OnEnable() 
    {
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }

    private void OnLevelFinishedLoading(UnityEngine.SceneManagement.Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Monster Chase Gameplay")
            Instantiate(players[_playerIndex]);
    }
}
