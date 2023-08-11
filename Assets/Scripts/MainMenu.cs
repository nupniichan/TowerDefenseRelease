using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public string levelToLoad = "MainLevel";

    public SceneFaded sceneFaded;

    public void Play()
    {
        sceneFaded.FadeTo(levelToLoad);
    }
    public void Quit()
    {
        Debug.Log("Exciting...");
        Application.Quit();
    } 
}
