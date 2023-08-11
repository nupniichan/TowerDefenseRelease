using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool isGameOver = false;

    public GameObject gameOverUI;
    public GameObject completeLevelUI;
    private void Start()
    {
        isGameOver = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
            return;

        if (Input.GetKeyDown("e"))
        {
            EndGame();
        }
        if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }
    void EndGame()
    {
        isGameOver = true;
        gameOverUI.SetActive(true);
    }
    public void WinLevel()
    {
        isGameOver = true;
        completeLevelUI.SetActive(true);
    }
}
