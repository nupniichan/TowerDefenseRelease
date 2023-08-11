using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneFaded : MonoBehaviour
{
    public Image img;
    public AnimationCurve curve; // giống cái chỉnh value bên after effect


    private void Start()
    {
        StartCoroutine(FadeIn());
    }

    public void FadeTo(string scene)
    {
        StartCoroutine(FadeOut(scene));
    }

    IEnumerator FadeIn() // black to scene
    {
        float time = 1f;

        while (time > 0f)
        {
            time -= Time.deltaTime;
            float alpha = curve.Evaluate(time);
            img.color = new Color(0f,0f,0f,alpha);
            yield return 0;
        }
    }

    IEnumerator FadeOut(string scene) // scence to black
    {
        float time = 0f;

        while (time < 1f)
        {
            time += Time.deltaTime;
            float alpha = curve.Evaluate(time);
            img.color = new Color(0f, 0f, 0f, alpha);
            yield return 0;
        }

        SceneManager.LoadScene(scene);
    }
}
