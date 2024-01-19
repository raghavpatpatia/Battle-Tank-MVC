using UnityEngine;

public class TankController
{
    private TankModel tankModel;
    private TankView tankView;

    public TankController(TankScriptableObject tankScriptableObject)
    {
        // TankModel
        tankModel = new TankModel(tankScriptableObject);
        tankModel.SetTankController(this);

        // Capture initial position
        Vector3 initialPosition = tankScriptableObject.tankView.transform.position;

        // TankView
        tankView = GameObject.Instantiate<TankView>(tankScriptableObject.tankView, initialPosition, Quaternion.identity);
        tankView.SetTankController(this);
    }
}
