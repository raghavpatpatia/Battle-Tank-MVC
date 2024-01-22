using UnityEngine;

public class TankService : MonoBehaviour
{
    [SerializeField] private TankScriptableObjectList tankScriptableObjectlist;
    private TankController tankController;

    private void Start()
    {
        CreateTank(Tank.Instance.tankType);
    }

    public void CreateTank(TankType tankType)
    {
        foreach (TankScriptableObject tankSO in tankScriptableObjectlist.list)
        {
            if (tankType == tankSO.tankType)
            {
                this.tankController = new TankController(tankSO);
            }
        }
    }
}