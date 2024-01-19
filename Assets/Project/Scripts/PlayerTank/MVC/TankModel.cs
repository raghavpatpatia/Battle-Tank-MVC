public class TankModel
{
    public TankController tankController {get; private set;}
    public void SetTankController(TankController tankController) => this.tankController = tankController;
    public TankModel(TankScriptableObject tankScriptableObject){}
}
