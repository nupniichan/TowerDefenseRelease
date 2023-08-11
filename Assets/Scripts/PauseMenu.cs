using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject ui;

    public string menuSceneName = "MainMenu";

    public SceneFaded sceneFaded;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            ToggleScence();
        }
    }

    private void ToggleScence()
    {
        ui.SetActive(!ui.activeSelf);

        if (ui.activeSelf)
        {
            // freezing game time
            Time.timeScale = 0f;
        }
        else
        {
            // enable game time again
            Time.timeScale = 1f;
        }
    }
    public void Retry()
    {
        ToggleScence();
        sceneFaded.FadeTo(SceneManager.GetActiveScene().name);
    }
    public void Menu()
    {
        ToggleScence();
        sceneFaded.FadeTo(menuSceneName);
    }
    public void Continue()
    {
        ui.SetActive(false);
        Time.timeScale = 1f;
    }
}
