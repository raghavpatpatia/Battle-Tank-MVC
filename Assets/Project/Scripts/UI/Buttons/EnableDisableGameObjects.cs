using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class EnableDisableGameObjects : MonoBehaviour
{
    private Button button;
    [SerializeField] private GameObject[] activateGameObjects;
    [SerializeField] private GameObject[] deactivategameObjects;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(EnableandDisable);
    }

    private void EnableandDisable()
    {
        foreach (GameObject deactivateGameObject in deactivategameObjects)
        {
            deactivateGameObject.SetActive(false);
        }

        foreach(GameObject activeGameObject in activateGameObjects)
        {
            activeGameObject.SetActive(true);
        }
    }
}