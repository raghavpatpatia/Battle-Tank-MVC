using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[System.Serializable]
public class TankSelection
{
    public TankType tankType;
    public Material tankMaterial;
}

[RequireComponent(typeof(Button))]
public class TankColorButtons : MonoBehaviour
{
    public TankSelection tankSelection;
    [SerializeField] private TankView tankView;
    private TankColor tankColor;
    private Button button;

    private void Start()
    {
        tankColor = new TankColor(tankView);
        button = GetComponent<Button>();
        button.onClick.AddListener(OnMouseClick);
    }

    private void OnMouseClick()
    {
        Tank.Instance.tankType = tankSelection.tankType;
        tankColor.ChangeColor(tankSelection.tankMaterial);
    }
}