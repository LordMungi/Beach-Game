using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Assets")]
    [Header("HUD")]
    [SerializeField] private Canvas HUDCanvas;
    [SerializeField] private TextMeshProUGUI conditionText;
    [Header("Pause")]
    [SerializeField] private Canvas pauseCanvas;
    [Header("Settings")]
    [SerializeField] private Canvas settingsCanvas;
    [Header("Win")]
    [SerializeField] private Canvas winLevelCanvas;
    [SerializeField] private Canvas winGameCanvas;

    [Header("Listener Events")]
    [SerializeField] private EventChannel PauseGameEvent;
    [SerializeField] private EventChannel UnpauseGameEvent;
    [SerializeField] private EventChannel WinLevelEvent;
    [SerializeField] private EventChannel WinGameEvent;

    private void OnEnable()
    {
        PauseGameEvent.OnEventTriggered += ShowPauseMenu;
        UnpauseGameEvent.OnEventTriggered += HidePauseMenu;
        WinLevelEvent.OnEventTriggered += ShowWinLevel;
        WinGameEvent.OnEventTriggered += ShowWinGame;

        conditionText.text = LevelManager.instance.currentLevel.conditionText;
    }

    private void OnDisable()
    {
        PauseGameEvent.OnEventTriggered -= ShowPauseMenu;
        UnpauseGameEvent.OnEventTriggered -= HidePauseMenu;
        WinLevelEvent.OnEventTriggered -= ShowWinLevel;
        WinGameEvent.OnEventTriggered -= ShowWinGame;
    }

    private void ShowPauseMenu()
    {
        HUDCanvas.gameObject.SetActive(false);
        pauseCanvas.gameObject.SetActive(true);
    }

    private void HidePauseMenu()
    {
        pauseCanvas.gameObject.SetActive(false);
        settingsCanvas.gameObject.SetActive(false);
        HUDCanvas.gameObject.SetActive(true);
    }

    public void ShowSettings()
    {
        pauseCanvas.gameObject.SetActive(false);
        settingsCanvas.gameObject.SetActive(true);
    }

    public void HideSettings()
    {
        settingsCanvas.gameObject.SetActive(false);
        ShowPauseMenu();
    }

    public void ShowWinLevel()
    {
        HUDCanvas.gameObject.SetActive(false);
        winLevelCanvas.gameObject.SetActive(true);
    }

    public void ShowWinGame()
    {
        HUDCanvas.gameObject.SetActive(false);
        winGameCanvas.gameObject.SetActive(true);
    }
}
