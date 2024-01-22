using UnityEngine;

public class TankController
{
    public TankModel tankModel { get; private set; }
    public TankView tankView { get; private set; }
    public Rigidbody rb { get; private set; }

    private TankMovement tankMovement;
    private TankColor tankColor;
    private Camera camera;

    public TankController(TankScriptableObject tankScriptableObject)
    {
        // TankModel
        tankModel = new TankModel(tankScriptableObject);
        tankModel.SetTankController(this);

        // TankView
        tankView = GameObject.Instantiate<TankView>(tankScriptableObject.tankView);
        tankView.SetTankController(this);

        // Other Initializations
        tankColor = new TankColor(tankView);
        ChangeTankMaterial();
        camera = Camera.main;
        camera.transform.parent = tankView.transform;
        rb = tankView.GetRigidbody();
        tankMovement = new TankMovement(this);
    }

    public void Move(float movement)
    {
        tankMovement.Move(movement);
    }

    public void Rotate(float rotation)
    {
        tankMovement.Rotate(rotation);
    }

    private void ChangeTankMaterial()
    {
        tankColor.ChangeColor(tankModel.tankMaterial);
    }
}
