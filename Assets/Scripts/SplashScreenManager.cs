using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SplashScreenManager : MonoBehaviour
{
    public Slider loadingSlider;

    void Start()
    {
        StartCoroutine(Wait3Sec());
    }

    IEnumerator Wait3Sec()
    {
        yield return new WaitForSeconds(2);
        loadingSlider.gameObject.SetActive(true);
        AsyncOperation operation = SceneManager.LoadSceneAsync(1);
        while (!operation.isDone)
        {
            loadingSlider.value = operation.progress;
            yield return null;
        }
    }
}
