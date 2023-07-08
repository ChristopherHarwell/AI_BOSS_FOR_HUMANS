using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuState : MonoBehaviour
{
    // References to UI elements
    public Image backgroundImage;
    public Image frame;
    public Image gameLogo;
    public Button startGameButton;
    public Button exitGameButton;
    public Text creditsText;

    private void Start()
    {
        // Disable by default
        this.enabled = false;

        // Assign button callbacks
        startGameButton.onClick.AddListener(StartGame);
        exitGameButton.onClick.AddListener(ExitGame);
    }

    private void StartGame()
    {
        SceneManager.Instance.SwitchState(GameState.HumanSelect);
    }

    private void ExitGame()
    {
        Application.Quit();
    }
}
