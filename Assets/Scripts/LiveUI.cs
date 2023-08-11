using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class LiveUI : MonoBehaviour
{
    public TextMeshProUGUI livesText;

    // Update is called once per frame
    void Update()
    {
        livesText.text = PlayerStats.Lives.ToString() + " Lives";
    }
}
