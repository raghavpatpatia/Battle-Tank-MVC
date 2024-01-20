using UnityEngine;

public class TankService : MonoBehaviour
{
    [SerializeField] private TankScriptableObjectList tankScriptableObjectlist;
    private TankController tankController;
    void Start()
    {
        CreateTank();
    }

    private void CreateTank()
    {
        this.tankController = new TankController(tankScriptableObjectlist.list[0]);
    }
}