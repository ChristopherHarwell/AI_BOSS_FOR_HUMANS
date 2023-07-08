using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    MainMenu,
    HumanSelect,
    Store,
    ShowDialog,
    ShowMiniGame,
    ShowResults
}

public class SceneManager : MonoBehaviour
{
    public GameState CurrentGameState { get; private set; }

    // State objects
    public MainMenuState mainMenuState;
    public HumanSelectState humanSelectState;
    public StoreState storeState;
    public ShowDialogState showDialogState;
    public ShowMiniGameState showMiniGameState;
    public ShowResultsState showResultsState;

    private void Start()
    {
        // Initialize game with main menu
        SwitchState(GameState.MainMenu);
    }

    public void SwitchState(GameState newState)
    {
        // Disable current state
        DisableCurrentState();

        // Switch state
        CurrentGameState = newState;

        // Enable new state
        EnableCurrentState();
    }

    private void DisableCurrentState()
    {
        switch (CurrentGameState)
        {
            case GameState.MainMenu:
                mainMenuState.enabled = false;
                break;
            case GameState.HumanSelect:
                humanSelectState.enabled = false;
                break;
            case GameState.Store:
                storeState.enabled = false;
                break;
            case GameState.ShowDialog:
                showDialogState.enabled = false;
                break;
            case GameState.ShowMiniGame:
                showMiniGameState.enabled = false;
                break;
            case GameState.ShowResults:
                showResultsState.enabled = false;
                break;
        }
    }

    private void EnableCurrentState()
    {
        switch (CurrentGameState)
        {
            case GameState.MainMenu:
                mainMenuState.enabled = true;
                break;
            case GameState.HumanSelect:
                humanSelectState.enabled = true;
                break;
            case GameState.Store:
                storeState.enabled = true;
                break;
            case GameState.ShowDialog:
                showDialogState.enabled = true;
                break;
            case GameState.ShowMiniGame:
                showMiniGameState.enabled = true;
                break;
            case GameState.ShowResults:
                showResultsState.enabled = true;
                break;
        }
    }
}
