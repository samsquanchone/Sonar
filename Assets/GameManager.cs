using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState {Normal, MenuOpen };
public class GameManager : MonoBehaviour
{
    public static GameManager Instance => m_instance;
    private static GameManager m_instance;

    private GameState state = GameState.Normal;


    private void Start()
    {
        m_instance = this;
    }

    public void WinGame()
    {

        SceneManager.LoadScene(3);
    }

    public void SetGameState(GameState newState)
    {
        state = newState;
    }

    public GameState GetGameState()
    {
        return state;
    }
}
