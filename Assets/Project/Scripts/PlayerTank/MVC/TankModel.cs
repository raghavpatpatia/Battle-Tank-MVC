public class TankModel
{
    public TankController tankController {get; private set;}
    public float tankSpeed { get; private set;}
    public float rotationSpeed { get; private set;}
    public void SetTankController(TankController tankController) => this.tankController = tankController;
    public TankModel(TankScriptableObject tankScriptableObject)
    {
        this.tankSpeed = tankScriptableObject.tankSpeed;
        this.rotationSpeed = tankScriptableObject.rotationSpeed;
    }
}
