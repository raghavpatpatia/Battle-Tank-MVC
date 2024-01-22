using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

[RequireComponent(typeof(Button))]
public class PlayButton : MonoBehaviour
{
    [SerializeField] private int buildIndex;
    [SerializeField] private Slider slider;
    private Button button;
    private Coroutine loadScene;
    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(LoadLevel);
    }

    private void LoadLevel()
    {
        if (loadScene != null)
        {
            StopCoroutine(loadScene);
        }
        loadScene = StartCoroutine(LoadSceneAsynchronously(buildIndex));
    }

    private IEnumerator LoadSceneAsynchronously(int buildIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(buildIndex);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            slider.value = progress;
            yield return null;
        }
    }
}