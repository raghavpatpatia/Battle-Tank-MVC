using UnityEngine;

public class TankService : MonoBehaviour
{
    [SerializeField] private TankScriptableObject tankScriptableObject;
    private TankController tankController;
    void Start()
    {
        this.tankController = new TankController(tankScriptableObject);
    }
}